// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using GenericMathsGenerator.ValueTypes;
using GenericMathsGenerator.VariableTypes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Operations;

namespace GenericMathsGenerator
{
    public partial class OperationWalker : Microsoft.CodeAnalysis.Operations.OperationWalker
    {
        private class Builder
        {    
            private sealed class Scope
            {
                public List<IVariable> Variables { get; } = new List<IVariable>();
                public List<Scope> Children { get; } = new List<Scope>();

                public IScope Resolve() => new IScopeImpl
                {
                    Variables = Variables,
                    Children = Children.Select(x => x.Resolve()).ToArray()
                };
            }
            
            private sealed class IScopeImpl : IScope
            {
                public IReadOnlyList<IVariable> Variables { get; set; }
                public IReadOnlyList<IScope> Children { get; set; }
            }
            
            private List<IValue>? _currentChildren;
            public IValue? CurrentValue { get; private set; }
            private Stack<(IValue, List<IValue>)> _parentLists = new Stack<(IValue, List<IValue>)>();

            private Scope? _currentScope;
            private Stack<Scope> _scopes = new Stack<Scope>();
            
            public int CurrentDepth => _parentLists.Count;

            public IScope ResolveCurrentScope() => _currentScope.Resolve();

            public void BeginScope()
            {
                if (_currentScope is not null)
                    _scopes.Push(_currentScope);

                _currentScope = new Scope();
            }

            public void EndScope()
            {
                var p = _scopes.Pop();
                p.Children.Add(_currentScope);
                _currentScope = p;
            }

            public void AddVariable(IVariable variable)
            {
                _currentScope.Variables.Add(variable);
            }
            
            public void BeginValue(IValue value)
            {
                if (CurrentValue is not null)
                {
                    _parentLists.Push((CurrentValue, _currentChildren));
                }
                CurrentValue = value;
                _currentChildren = new List<IValue>();
            }

            public void EndValue()
            {
                var v = CurrentValue.WithChildren(_currentChildren);
                if (_parentLists.Count > 0)
                {
                    (CurrentValue, _currentChildren) = _parentLists.Pop();
                    _currentChildren.Add(v);
                }
                else
                {
                    CurrentValue = v; // this is the root value
                }
            }
        }

        private Builder? _builder;
        private ITypeSymbol _floatType;
        private ITypeSymbol _intType;
        private int _returnCount = 0;
        private Dictionary<string, LocalVariable> _locals;
        private List<LocalReferenceValue> _localReferences;
        private Location _currentLocation;

        public IScope? RootVisit(GeneratorExecutionContext context, IOperation root)
        {
            _locals = new Dictionary<string, LocalVariable>();
            _localReferences = new List<LocalReferenceValue>();
            _floatType = context.Compilation.GetSpecialType(SpecialType.System_Single);
            _intType = context.Compilation.GetSpecialType(SpecialType.System_Int32);
            try
            {
                _currentLocation = root.Syntax.GetLocation();
                _builder = new Builder();
                _builder.BeginScope();
                base.Visit(root);
                _builder.EndScope();
            }
            catch (DiagnosticException ex)
            {
                context.ReportDiagnostic(ex.Diagnostic);
            }
            catch (Exception ex)
            {
                context.ReportDiagnostic(Diagnostic.Create(Diagnostics.UnexpectedWalkerException, _currentLocation, ex.ToString()));
            }

            ResolveReferences();
            var s = _builder.ResolveCurrentScope();
            _builder = null;
            return s;
        }

        private void ResolveReferences()
        {
            for (var index = 0; index < _localReferences.Count; index++)
            {
                var localReference = _localReferences[index];
                localReference.LocalVariable = _locals[localReference.Name];
                _locals[localReference.Name].References.Add(localReference);
                _localReferences[index] = localReference;
            }
        }

        public override void VisitFieldReference(IFieldReferenceOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            Debug.Assert(_builder is not null, "_builder is null");
            
            _builder.BeginValue(new FieldReferenceValue(operation.Field.Name));
            base.VisitFieldReference(operation);
            _builder.EndValue();
        }

        public override void VisitPropertyReference(IPropertyReferenceOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            Debug.Assert(_builder is not null, "_builder is null");
            
            _builder.BeginValue(new PropertyReferenceValue(operation.Property.Name));
            base.VisitPropertyReference(operation);
            _builder.EndValue();
        }

        public override void VisitParameterReference(IParameterReferenceOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            Debug.Assert(_builder is not null, "_builder is null");
        
            _builder.BeginValue(new ParameterReferenceValue(operation.Parameter.Name));
            base.VisitParameterReference(operation);
            _builder.EndValue();
        }

        public override void VisitReturn(IReturnOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            
            _returnCount++;
            if (_returnCount > 1)
            {
                throw new DiagnosticException(Diagnostic.Create(Diagnostics.ComplexReturn, _currentLocation));
            }

            var oldBuilder = _builder;
            _builder = new Builder();
            base.VisitReturn(operation);
            VerifyBuilderComplete(operation);
            _builder.AddVariable(new ReturnVariable(_builder.CurrentValue));
            _builder = oldBuilder;
        }

        public override void VisitVariableDeclaration(IVariableDeclarationOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            
            foreach (var declarator in operation.Declarators)
            {
                var oldBuilder = _builder;
                _builder = new Builder();
                base.VisitVariableDeclarator(declarator);
                VerifyBuilderComplete(declarator);
                var v = new LocalVariable(declarator.Symbol.Name, _builder.CurrentValue);
                _builder.AddVariable(v);
                _locals[declarator.Symbol.Name] = v;
                _builder = oldBuilder;
            }
        }

        public override void VisitLocalReference(ILocalReferenceOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            Debug.Assert(_builder is not null, "_builder is null");
            
            var r = new LocalReferenceValue(operation.Local.Name);
            _builder.BeginValue(r);
            _localReferences.Add(r);
            base.VisitLocalReference(operation);
            _builder.EndValue();
        }

        private void VerifyBuilderComplete(IOperation o)
        {
            Debug.Assert(_builder is not null, "_builder is null");

            if (_builder.CurrentDepth > 0)
            {
                throw new DiagnosticException(Diagnostic.Create(Diagnostics.IncompleteExpression, _currentLocation, _builder.CurrentDepth));
            }
        }

        public override void VisitBinaryOperator(IBinaryOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            Debug.Assert(_builder is not null, "_builder is null");

            BinaryOperatorValue value = operation.OperatorKind switch
            {
                BinaryOperatorKind.Add => new AddValue(),
                BinaryOperatorKind.Subtract => new SubtractValue(),
                BinaryOperatorKind.Multiply => new MultiplyValue(),
                BinaryOperatorKind.Divide => new DivideValue(),
                /*BinaryOperatorKind.IntegerDivide => new IntegerDivideValue(),
                BinaryOperatorKind.Remainder => new RemainderValue(),
                BinaryOperatorKind.LeftShift => new LeftShiftValue(),
                BinaryOperatorKind.RightShift => new RightShiftValue(),
                BinaryOperatorKind.And => new AndValue(),
                BinaryOperatorKind.Or => new OrValue(),
                BinaryOperatorKind.ExclusiveOr => new XorValue(),
                BinaryOperatorKind.ConditionalAnd => new ConditionalAndValue(),
                BinaryOperatorKind.ConditionalOr => new ConditionalOrValue(),
                BinaryOperatorKind.Equals => new EqualsValue(),
                BinaryOperatorKind.NotEquals => new NotEqualsValue(),
                BinaryOperatorKind.LessThan => new LessThanValue(),
                BinaryOperatorKind.LessThanOrEqual => new LessThanOrEqualValue(),
                BinaryOperatorKind.GreaterThanOrEqual => new GreaterThanOrEqualValue(),
                BinaryOperatorKind.GreaterThan => new GreaterThanValue(),*/
                _ => throw new DiagnosticException
                (
                    Diagnostic.Create
                    (
                        Diagnostics.UnsupportedOperator, _currentLocation,
                        Enum.GetName(typeof(BinaryOperatorKind), operation.OperatorKind)
                    )
                )
            };

            _builder.BeginValue(value);
            base.VisitBinaryOperator(operation);
            _builder.EndValue();
        }

        public override void VisitUnaryOperator(IUnaryOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            Debug.Assert(_builder is not null, "_builder is null");

            UnaryOperatorValue? value = operation.OperatorKind switch
            {
                UnaryOperatorKind.Plus => null, // ignore
                UnaryOperatorKind.Minus => new NegateValue(),
                _ => throw new DiagnosticException
                (
                    Diagnostic.Create
                    (
                        Diagnostics.UnsupportedOperator, _currentLocation,
                        Enum.GetName(typeof(UnaryOperatorKind), operation.OperatorKind)
                    )
                )
            };

            if (value is not null) 
                _builder.BeginValue(value);

            base.VisitUnaryOperator(operation);
            
            if (value is not null)
                _builder.EndValue();
        }

        public override void VisitLiteral(ILiteralOperation operation)
        {
            _currentLocation = operation.Syntax.GetLocation();
            Debug.Assert(_builder is not null, "_builder is null");

            if (SymbolEqualityComparer.IncludeNullability.Equals(operation.Type, _floatType))
            {
                if (!operation.ConstantValue.HasValue)
                {
#if DEBUG
                    Debugger.Launch();
                    Debugger.Break();
#endif
                    Debug.Fail("non-constant literal?!");
                }

                _builder.BeginValue(new LiteralValue((float) operation.ConstantValue.Value));
                base.VisitLiteral(operation);
                _builder.EndValue();
            }
            else if (SymbolEqualityComparer.IncludeNullability.Equals(operation.Type, _intType))
            {
                if (!operation.ConstantValue.HasValue)
                {

#if DEBUG
                    Debugger.Launch();
                    Debugger.Break();
#endif
                    Debug.Fail("non-constant literal?!");
                }

                _builder.BeginValue(new LiteralValue((float)(int) operation.ConstantValue.Value));
                base.VisitLiteral(operation);
                _builder.EndValue();
            }
            else
            {
                throw new DiagnosticException(Diagnostic.Create(Diagnostics.TypeMissmatch, _currentLocation, operation.Type.Name));
            }
        }
    }
}
