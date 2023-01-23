/*!

 =========================================================
 * Argon Design System - v1.2.2
 =========================================================

 * Product Page: https://www.creative-tim.com/product/argon-design-system
 * Copyright 2020 Creative Tim (http://www.creative-tim.com)

 * Coded by www.creative-tim.com

 =========================================================

 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

 */


 var transparent = true;
 var big_image;
 
 var transparentDemo = true;
 var fixedTop = false;
 
 var navbar_initialized,
   backgroundOrange = false,
   toggle_initialized = false;
 
 var $datepicker = $('.datepicker');
 var $collapse = $('.navbar .collapse');
 var $html = $('html');
 var $tagsinput = $('.tagsinput');
 
 
 $(document).ready(function() {
   //  Activate the Tooltips
   $('[data-toggle="tooltip"], [rel="tooltip"]').tooltip();
 
   // Activate Popovers and set color for popovers
   $('[data-toggle="popover"]').each(function() {
     color_class = $(this).data('color');
     $(this).popover({
       template: '<div class="popover popover-' + color_class + '" role="tooltip"><div class="arrow"></div><h3 class="popover-header"></h3><div class="popover-body"></div></div>'
     });
   });
 
   var squares1 = document.getElementById("square1");
   var squares2 = document.getElementById("square2");
   var squares3 = document.getElementById("square3");
   var squares4 = document.getElementById("square4");
   var squares5 = document.getElementById("square5");
   var squares6 = document.getElementById("square6");
   var squares9 = document.getElementById("square7");
   var squares10 = document.getElementById("square8");
 
   if ($('.square').length != 0) {
 
     $(document).mousemove(function(e) {
       posX = event.clientX - window.innerWidth / 2;
       posY = event.clientY - window.innerWidth / 6;
 
       squares1.style.transform = "perspective(500px) rotateY(" + posX * 0.05 + "deg) rotateX(" + posY * (-0.05) + "deg)";
       squares2.style.transform = "perspective(500px) rotateY(" + posX * 0.05 + "deg) rotateX(" + posY * (-0.05) + "deg)";
       squares3.style.transform = "perspective(500px) rotateY(" + posX * 0.05 + "deg) rotateX(" + posY * (-0.05) + "deg)";
       squares4.style.transform = "perspective(500px) rotateY(" + posX * 0.05 + "deg) rotateX(" + posY * (-0.05) + "deg)";
       squares5.style.transform = "perspective(500px) rotateY(" + posX * 0.05 + "deg) rotateX(" + posY * (-0.05) + "deg)";
       squares6.style.transform = "perspective(500px) rotateY(" + posX * 0.05 + "deg) rotateX(" + posY * (-0.05) + "deg)";
       squares9.style.transform = "perspective(500px) rotateY(" + posX * 0.02 + "deg) rotateX(" + posY * (-0.02) + "deg)";
       squares10.style.transform = "perspective(500px) rotateY(" + posX * 0.02 + "deg) rotateX(" + posY * (-0.02) + "deg)";
 
     });
   }
 
   // Activate the image for the navbar-collapse
   ArgonKit.initNavbarImage();
 
   $navbar = $('.navbar[color-on-scroll]');
   scroll_distance = $navbar.attr('color-on-scroll') || 500;
 
   // Check if we have the class "navbar-color-on-scroll" then add the function to remove the class "navbar-transparent" so it will transform to a plain color.
 
   if ($('.navbar[color-on-scroll]').length != 0) {
     ArgonKit.checkScrollForTransparentNavbar();
     $(window).on('scroll', ArgonKit.checkScrollForTransparentNavbar)
   }
 
   $('.form-control').on("focus", function() {
     $(this).parent('.input-group').addClass("input-group-focus");
   }).on("blur", function() {
     $(this).parent(".input-group").removeClass("input-group-focus");
   });
 
   // Activate bootstrapSwitch
   $('.bootstrap-switch').each(function() {
     $this = $(this);
     data_on_label = $this.data('on-label') || '';
     data_off_label = $this.data('off-label') || '';
 
     $this.bootstrapSwitch({
       onText: data_on_label,
       offText: data_off_label
     });
   });
 
   // Activate Carousel
   $('.carousel').carousel({
     interval: false
   });
 
   // Datepicker
   $('.datepicker')[0] && $('.datepicker').each(function() {
     $('.datepicker').datepicker({
       disableTouchKeyboard: true,
       autoclose: false
     });
   });
 
 
   // Datepicker
   flatpickr('.flatpickr', {});
 
   // Datepicker - range
   flatpickr('.range', {
     mode: "range"
   });
 
   // DateTimePicker
   flatpickr('.datetimepicker', {
     enableTime: true,
     dateFormat: "Y-m-d H:i",
   });
 
   // Activate Sliders
   ArgonKit.initSliders();
 
 });
 
 // Methods
 
 function hideNavbarCollapse($this) {
   $this.addClass('collapsing-out');
 }
 
 function hiddenNavbarCollapse($this) {
   $this.removeClass('collapsing-out');
 }
 
 
 // Events
 
 if ($collapse.length) {
   $collapse.on({
     'hide.bs.collapse': function() {
       hideNavbarCollapse($collapse);
     }
   })
 
   $collapse.on({
     'hidden.bs.collapse': function() {
       hiddenNavbarCollapse($collapse);
     }
   })
 }
 
 
 // Returns a function, that, as long as it continues to be invoked, will not
 // be triggered. The function will be called after it stops being called for
 // N milliseconds. If `immediate` is passed, trigger the function on the
 // leading edge, instead of the trailing.
 
 function debounce(func, wait, immediate) {
   var timeout;
   return function() {
     var context = this,
       args = arguments;
     clearTimeout(timeout);
     timeout = setTimeout(function() {
       timeout = null;
       if (!immediate) func.apply(context, args);
     }, wait);
     if (immediate && !timeout) func.apply(context, args);
   };
 };
 
 
 ArgonKit = {
   misc: {
     navbar_menu_visible: 0
   },
 
   checkScrollForTransparentNavbar: debounce(function() {
     if ($(document).scrollTop() > scroll_distance) {
       if (transparent) {
         transparent = false;
         $('.navbar[color-on-scroll]').removeClass('navbar-transparent');
       }
     } else {
       if (!transparent) {
         transparent = true;
         $('.navbar[color-on-scroll]').addClass('navbar-transparent');
       }
     }
   }, 17),
 
   initNavbarImage: function() {
     var $navbar = $('.navbar').find('.navbar-translate').siblings('.navbar-collapse');
     var background_image = $navbar.data('nav-image');
 
     if ($(window).width() < 991 || $('body').hasClass('burger-menu')) {
       if (background_image != undefined) {
         $navbar.css('background', "url('" + background_image + "')")
           .removeAttr('data-nav-image')
           .css('background-size', "cover")
           .addClass('has-image');
       }
     } else if (background_image != undefined) {
       $navbar.css('background', "")
         .attr('data-nav-image', '' + background_image + '')
         .css('background-size', "")
         .removeClass('has-image');
     }
   },
 
   initDatePicker: function() {
     if ($datepicker.length != 0) {
       $datepicker.datetimepicker({
         icons: {
           time: "tim-icons icon-watch-time",
           date: "tim-icons icon-calendar-60",
           up: "fa fa-chevron-up",
           down: "fa fa-chevron-down",
           previous: 'tim-icons icon-minimal-left',
           next: 'tim-icons icon-minimal-right',
           today: 'fa fa-screenshot',
           clear: 'fa fa-trash',
           close: 'fa fa-remove'
         }
       });
     }
   },
 
   initSliders: function() {
     // Sliders for demo purpose in refine cards section
     var slider = document.getElementById('sliderRegular');
     if ($('#sliderRegular').length != 0) {
 
       noUiSlider.create(slider, {
         start: 40,
         connect: [true, false],
         range: {
           min: 0,
           max: 100
         }
       });
     }
 
     var slider2 = document.getElementById('sliderDouble');
 
     if ($('#sliderDouble').length != 0) {
 
       noUiSlider.create(slider2, {
         start: [20, 60],
         connect: true,
         range: {
           min: 0,
           max: 100
         }
       });
     }
   }
 }
 
 
 
 // Returns a function, that, as long as it continues to be invoked, will not
 // be triggered. The function will be called after it stops being called for
 // N milliseconds. If `immediate` is passed, trigger the function on the
 // leading edge, instead of the trailing.
 
 function debounce(func, wait, immediate) {
   var timeout;
   return function() {
     var context = this,
       args = arguments;
     clearTimeout(timeout);
     timeout = setTimeout(function() {
       timeout = null;
       if (!immediate) func.apply(context, args);
     }, wait);
     if (immediate && !timeout) func.apply(context, args);
   };
 };