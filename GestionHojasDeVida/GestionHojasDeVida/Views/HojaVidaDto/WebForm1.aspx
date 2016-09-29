﻿ <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GestionHojasDeVida.Views.WebForm1" %>
@inherits System.Web.Mvc.WebViewPage
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width" />
    <link rel="profile" href="http://gmpg.org/xfn/11" />
    <link rel="pingback" href="http://alexgurghis.com/themes/jobsdojo/xmlrpc.php" />

    <title>Registro HV</title>
    <link rel="alternate" type="application/rss+xml" title="JobsDojo &raquo; Feed" href="http://alexgurghis.com/themes/jobsdojo/feed/" />
    <link rel="alternate" type="application/rss+xml" title="JobsDojo &raquo; Comments Feed" href="http://alexgurghis.com/themes/jobsdojo/comments/feed/" />
    <link rel='stylesheet' id='bootstrap-css' href='http://alexgurghis.com/themes/jobsdojo/wp-content/themes/jobsdojo/css/bootstrap.min.css?ver=1.0.0' type='text/css' media='all' />
    <link href="~/Css/General_Registro.css" rel="stylesheet" />
    <link rel='stylesheet' id='jobsdojo-fonts-css' href='https://fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700&#038;subset=latin,latin-ext' type='text/css' media='all' />
    <link rel='stylesheet' id='mytheme-roboto-css' href='http://fonts.googleapis.com/css?family=Roboto+Condensed%3A400%2C300%2C300italic%2C400italic%2C700%2C700italic&#038;ver=4.5.3' type='text/css' media='all' />
    <link rel='stylesheet' id='custom-style-css' href='http://alexgurghis.com/themes/jobsdojo/wp-content/themes/jobsdojo/css/custom-styles.css?ver=4.5.3' type='text/css' media='all' />
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/jquery.js?ver=1.12.4'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/jquery-migrate.min.js?ver=1.4.1'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var SnazzyDataForSnazzyMaps = [];
        SnazzyDataForSnazzyMaps = { "id": 38, "name": "Shades of Grey", "description": "A map with various shades of grey. Great for a website with a really dark theme. ", "url": "https:\/\/snazzymaps.com\/style\/38\/shades-of-grey", "imageUrl": "https:\/\/az769952.vo.msecnd.net\/assets\/38-shades-of-grey.png?v=20160316033540", "json": "[{\"featureType\":\"all\",\"elementType\":\"labels.text.fill\",\"stylers\":[{\"saturation\":36},{\"color\":\"#000000\"},{\"lightness\":40}]},{\"featureType\":\"all\",\"elementType\":\"labels.text.stroke\",\"stylers\":[{\"visibility\":\"on\"},{\"color\":\"#000000\"},{\"lightness\":16}]},{\"featureType\":\"all\",\"elementType\":\"labels.icon\",\"stylers\":[{\"visibility\":\"off\"}]},{\"featureType\":\"administrative\",\"elementType\":\"geometry.fill\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":20}]},{\"featureType\":\"administrative\",\"elementType\":\"geometry.stroke\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":17},{\"weight\":1.2}]},{\"featureType\":\"landscape\",\"elementType\":\"geometry\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":20}]},{\"featureType\":\"poi\",\"elementType\":\"geometry\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":21}]},{\"featureType\":\"road.highway\",\"elementType\":\"geometry.fill\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":17}]},{\"featureType\":\"road.highway\",\"elementType\":\"geometry.stroke\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":29},{\"weight\":0.2}]},{\"featureType\":\"road.arterial\",\"elementType\":\"geometry\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":18}]},{\"featureType\":\"road.local\",\"elementType\":\"geometry\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":16}]},{\"featureType\":\"transit\",\"elementType\":\"geometry\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":19}]},{\"featureType\":\"water\",\"elementType\":\"geometry\",\"stylers\":[{\"color\":\"#000000\"},{\"lightness\":17}]}]", "views": 139251, "favorites": 260, "createdBy": { "name": "Adam Krogh", "url": "http:\/\/atmist.com" }, "createdOn": "2013-11-12T18:21:41.94" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/plugins/snazzy-maps/snazzymaps.js?ver=1.1.1'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var jobsdojoMapSettings = { "url_icon": "http:\/\/alexgurghis.com\/themes\/jobsdojo\/wp-content\/themes\/jobsdojo\/images\/map-pin.png", "url_theme": "http:\/\/alexgurghis.com\/themes\/jobsdojo\/wp-content\/themes\/jobsdojo", "results_no": "Results" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/themes/jobsdojo/js/wp-job-manager-map.js?ver=4.5.3'></script>
    <link rel='https://api.w.org/' href='http://alexgurghis.com/themes/jobsdojo/wp-json/' />
    <link rel="EditURI" type="application/rsd+xml" title="RSD" href="http://alexgurghis.com/themes/jobsdojo/xmlrpc.php?rsd" />
    <link rel="wlwmanifest" type="application/wlwmanifest+xml" href="http://alexgurghis.com/themes/jobsdojo/wp-includes/wlwmanifest.xml" />
    <meta name="generator" content="WordPress 4.5.3" />
    <meta name="generator" content="WooCommerce 2.5.5" />
    <link rel="canonical" href="http://alexgurghis.com/themes/jobsdojo/submit-resume/" />
    <link rel='shortlink' href='http://alexgurghis.com/themes/jobsdojo/?p=55' />
    <link rel="alternate" type="application/json+oembed" href="http://alexgurghis.com/themes/jobsdojo/wp-json/oembed/1.0/embed?url=http%3A%2F%2Falexgurghis.com%2Fthemes%2Fjobsdojo%2Fsubmit-resume%2F" />
    <link rel="alternate" type="text/xml+oembed" href="http://alexgurghis.com/themes/jobsdojo/wp-json/oembed/1.0/embed?url=http%3A%2F%2Falexgurghis.com%2Fthemes%2Fjobsdojo%2Fsubmit-resume%2F&#038;format=xml" />



</head>

<body class="page page-id-55 page-template-default custom-font-enabled single-author page-add-listing jobsdojo">

    <!-- page-overlay -->
    <div id="pageloader">
        <div class="progress">
            <div class="indeterminate"></div>
        </div>
    </div>
    <!-- /.page-overlay -->
    <!-- fixed borders and fixed contacts -->
    <div class="top-br"></div>
    <div class="right-br"></div>
    <div class="bottom-br"></div>
    <div class="left-br"></div>

    <!-- NavBar Fixed to top -->
    <nav style="height:70px" id="jobsdojo-menu" class="navbar navbar-default fadeInDown">

        <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#top-menu" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <div class="prueba">
                    <div class="header">
                        <br>
                        <div>Gestión<span> Hojas De Vida</span></div>
                    </div>
                </div>


            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse pull-right" id="top-menu">
                <ul class="nav navbar-nav text-uppercase text-center">
                    <li id="menu-item-210" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-has-children has-submenu menu-item-210">
                        @Html.ActionLink("Inicio", "Main", "UsuarioLoginDTO")
                    </li>
                    <li id="menu-item-27" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-has-children has-submenu menu-item-27">
                        <a href="Registro">Empleado</a>
                        <ul class="sub-menu">
                            <li id="menu-item-205" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-205">@Html.ActionLink("Registrar", "Index", "RegistroUsuarioDTO")</li>
                            <li id="menu-item-205" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-205">@Html.ActionLink("Consultar", "Consulta", "HojaVidaDto") </li>
                            <li id="menu-item-205" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-205">@Html.ActionLink("Inactivar", "Inactivar", "Inactivar")</li>
                        </ul>
                    <li id="menu-item-27" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-has-children has-submenu menu-item-27">
                        <a href=#>Hoja de Vida</a>
                        <ul class="sub-menu">
                            <li id="menu-item-35" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-35"><a href="~/Views/HojaVidaDto/Index.cshtml">Datos Personales</a></li>
                            <li id="menu-item-205" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-205">@Html.ActionLink("Experiencia", "Experiencia", "Experiencia")</li>
                            <li id="menu-item-205" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-205">@Html.ActionLink("Formación", "Estudio", "Estudios")</li>
                            <li id="menu-item-205" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-205"><a href="Registro">Habilidades</a></li>
                        </ul>
                    <li id="menu-item-210" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-has-children has-submenu menu-item-210">
                        @Html.ActionLink("Logout", "Login", "UsuarioLoginDTO")
                    </li>

                </ul>
            </div><!-- /.navbar-collapse -->

        </div><!-- /.container-fluid -->

    </nav>

    <div id="page-content">

        <header style="background-color: darkblue ; height:100px"></header>

        <div id="main">
            <section>
                <div class="container">
                    <div class="row text-center">
                        <h2>Consulta de Empleado</h2>
                        
                    </div>
                </div>
                <div class="container">


                    <article id="post-55" class="post-55 page type-page status-publish hentry">
                        <div class="entry-content">
                            <br><br>
                                <!-- Resume Fields -->
                                <fieldset class="fieldset-resume_category">
                                    <label for="resume_category">Tipo de Contrato:</label>  @ViewBag.Tipo_Contrato
                                    
                                   
                                </fieldset>
                            <br>

                                <fieldset class="fieldset-resume_category">
                                    <label for="resume_category">Tipo de Documento:</label>  @ViewBag.Tipo_Documento
                                  
                                </fieldset>
                            <br>

                                <fieldset class="fieldset-candidate_name">
                                    <label for="candidate_name">No Documento:</label>  @ViewBag.NumDocumento
                                   
                                </fieldset>
                            <br>

                                <fieldset class="fieldset-candidate_name">
                                    <label for="candidate_name">Nombres:</label>  @ViewBag.Nombres
                                    
                                </fieldset>
                            <br>

                                <fieldset class="fieldset-candidate_name">
                                    <label for="candidate_name">Apellidos:</label>  @ViewBag.Apellidos
                                    
                                </fieldset>
                            <br>
                                <fieldset class="fieldset-candidate_email">
                                    <label for="candidate_email">Correo Electronico:</label>  @ViewBag.Email
                                   
                                </fieldset>
                            <br>

                                <fieldset class="fieldset-candidate_location">
                                    <label for="candidate_location">Cargo:</label>  @ViewBag.Cargo
                                    
                                </fieldset>
                            <br>

                                <fieldset class="fieldset-candidate_location">
                                    <label for="candidate_location">Salario:</label>  @ViewBag.Salario
                                    
                                </fieldset>
                            <br>
                          
                        </div><!-- .entry-content -->
                    </article><!-- #post -->

                </div>
            </section>
        </div>


    </div>

    <script type='text/javascript'>
        /* <![CDATA[ */
        var wc_add_to_cart_params = { "ajax_url": "\/themes\/jobsdojo\/wp-admin\/admin-ajax.php", "wc_ajax_url": "\/themes\/jobsdojo\/submit-resume\/?wc-ajax=%%endpoint%%", "i18n_view_cart": "View Cart", "cart_url": "http:\/\/alexgurghis.com\/themes\/jobsdojo\/cart\/", "is_cart": "", "cart_redirect_after_add": "no" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='//alexgurghis.com/themes/jobsdojo/wp-content/plugins/woocommerce/assets/js/frontend/add-to-cart.min.js?ver=2.5.5'></script>
    <script type='text/javascript' src='//alexgurghis.com/themes/jobsdojo/wp-content/plugins/woocommerce/assets/js/jquery-blockui/jquery.blockUI.min.js?ver=2.70'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var woocommerce_params = { "ajax_url": "\/themes\/jobsdojo\/wp-admin\/admin-ajax.php", "wc_ajax_url": "\/themes\/jobsdojo\/submit-resume\/?wc-ajax=%%endpoint%%" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='//alexgurghis.com/themes/jobsdojo/wp-content/plugins/woocommerce/assets/js/frontend/woocommerce.min.js?ver=2.5.5'></script>
    <script type='text/javascript' src='//alexgurghis.com/themes/jobsdojo/wp-content/plugins/woocommerce/assets/js/jquery-cookie/jquery.cookie.min.js?ver=1.4.1'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var wc_cart_fragments_params = { "ajax_url": "\/themes\/jobsdojo\/wp-admin\/admin-ajax.php", "wc_ajax_url": "\/themes\/jobsdojo\/submit-resume\/?wc-ajax=%%endpoint%%", "fragment_name": "wc_fragments" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='//alexgurghis.com/themes/jobsdojo/wp-content/plugins/woocommerce/assets/js/frontend/cart-fragments.min.js?ver=2.5.5'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/themes/jobsdojo/js/navigation.js?ver=20140711'></script>
    <script type='text/javascript' src='https://maps.googleapis.com/maps/api/js?ver=2013-07-18'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/themes/jobsdojo/js/bundle.js?ver=4.5.3'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var jobsdojo_params = { "home_url": "http:\/\/alexgurghis.com\/themes\/jobsdojo\/", "page_bg_url": "http:\/\/alexgurghis.com\/themes\/jobsdojo\/wp-content\/themes\/jobsdojo\/images\/title-bg.jpg", "login_url": "http:\/\/alexgurghis.com\/themes\/jobsdojo\/wp-login.php", "strings": { "wp-job-manager-file-upload": "Adicionar ARchivo", "no_job_listings_found": "No results", "results-no": "Results" } };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/themes/jobsdojo/js/main.js?ver=20151230'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/themes/jobsdojo/js/functions.js?ver=2013-07-18'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var job_manager_chosen_multiselect_args = { "search_contains": "1" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='//alexgurghis.com/themes/jobsdojo/wp-content/plugins/woocommerce/assets/js/chosen/chosen.jquery.min.js?ver=1.0.0'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/plugins/wp-job-manager-locations//assets/js/main.js?ver=20140525'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/wp-embed.min.js?ver=4.5.3'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/ui/core.min.js?ver=1.11.4'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/ui/widget.min.js?ver=1.11.4'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/ui/mouse.min.js?ver=1.11.4'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/ui/sortable.min.js?ver=1.11.4'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var resume_manager_resume_submission = { "i18n_navigate": "If you wish to edit the posted details use the \"edit resume\" button instead, otherwise changes may be lost.", "i18n_confirm_remove": "Are you sure you want to remove this item?", "i18n_remove": "remove" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/plugins/wp-job-manager-resumes/assets/js/resume-submission.min.js?ver=1.11.3'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/plugins/wp-job-manager/assets/js/jquery-fileupload/jquery.iframe-transport.js?ver=1.8.3'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/plugins/wp-job-manager/assets/js/jquery-fileupload/jquery.fileupload.js?ver=9.11.2'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var job_manager_ajax_file_upload = { "ajax_url": "\/themes\/jobsdojo\/jm-ajax\/%%endpoint%%\/", "js_field_html_img": "<div class=\"job-manager-uploaded-file\">\t\t\t<span class=\"job-manager-uploaded-file-preview\"><img src=\"\" \/> <a class=\"job-manager-remove-uploaded-file\" href=\"#\">[remove]<\/a><\/span>\t\t<input type=\"hidden\" class=\"input-text\" name=\"\" value=\"\" \/><\/div>", "js_field_html": "<div class=\"job-manager-uploaded-file\">\t\t\t<span class=\"job-manager-uploaded-file-name\"><code><\/code> <a class=\"job-manager-remove-uploaded-file\" href=\"#\">[remove]<\/a><\/span>\t\t<input type=\"hidden\" class=\"input-text\" name=\"\" value=\"\" \/><\/div>", "i18n_invalid_file_type": "Invalid file type. Accepted types:" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/plugins/wp-job-manager/assets/js/ajax-file-upload.min.js?ver=1.25.0'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-content/plugins/wp-job-manager/assets/js/term-multiselect.min.js?ver=1.25.0'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var userSettings = { "url": "\/themes\/jobsdojo\/", "uid": "0", "time": "1470455171", "secure": "" };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/utils.min.js?ver=4.5.3'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-admin/js/editor.min.js?ver=4.5.3'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/wp-a11y.min.js?ver=4.5.3'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var wpLinkL10n = { "title": "Insert\/edit link", "update": "Update", "save": "Add Link", "noTitle": "(no title)", "noMatchesFound": "No results found.", "linkSelected": "Link selected.", "linkInserted": "Link inserted." };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/wplink.min.js?ver=4.5.3'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/ui/position.min.js?ver=1.11.4'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/ui/menu.min.js?ver=1.11.4'></script>
    <script type='text/javascript'>
        /* <![CDATA[ */
        var uiAutocompleteL10n = { "noResults": "No search results.", "oneResult": "1 result found. Use up and down arrow keys to navigate.", "manyResults": "%d results found. Use up and down arrow keys to navigate." };
        /* ]]> */
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/jquery/ui/autocomplete.min.js?ver=1.11.4'></script>

    <script type="text/javascript">
        tinyMCEPreInit = {
            baseURL: "http://alexgurghis.com/themes/jobsdojo/wp-includes/js/tinymce",
            suffix: ".min",
            mceInit: { 'resume_content': { theme: "modern", skin: "lightgray", language: "en", formats: { alignleft: [{ selector: "p,h1,h2,h3,h4,h5,h6,td,th,div,ul,ol,li", styles: { textAlign: "left" } }, { selector: "img,table,dl.wp-caption", classes: "alignleft" }], aligncenter: [{ selector: "p,h1,h2,h3,h4,h5,h6,td,th,div,ul,ol,li", styles: { textAlign: "center" } }, { selector: "img,table,dl.wp-caption", classes: "aligncenter" }], alignright: [{ selector: "p,h1,h2,h3,h4,h5,h6,td,th,div,ul,ol,li", styles: { textAlign: "right" } }, { selector: "img,table,dl.wp-caption", classes: "alignright" }], strikethrough: { inline: "del" } }, relative_urls: false, remove_script_host: false, convert_urls: false, browser_spellcheck: true, fix_list_elements: true, entities: "38,amp,60,lt,62,gt", entity_encoding: "raw", keep_styles: false, cache_suffix: "wp-mce-4310-20160418", preview_styles: "font-family font-size font-weight font-style text-decoration text-transform", end_container_on_empty_block: true, wpeditimage_disable_captions: false, wpeditimage_html5_captions: true, plugins: "lists,paste,tabfocus,wplink,wordpress", wp_lang_attr: "en-US", content_css: "http://alexgurghis.com/themes/jobsdojo/wp-includes/css/dashicons.min.css?ver=4.5.3,http://alexgurghis.com/themes/jobsdojo/wp-includes/js/tinymce/skins/wordpress/wp-content.css?ver=4.5.3,https://fonts.googleapis.com/css?family=Open+Sans:400italic%2C700italic%2C400%2C700&subset=latin%2Clatin-ext", selector: "#resume_content", resize: "vertical", menubar: false, wpautop: true, indent: false, toolbar1: "bold,italic,|,bullist,numlist,|,link,unlink,|,undo,redo", toolbar2: "", toolbar3: "", toolbar4: "", tabfocus_elements: ":prev,:next", body_class: "resume_content post-type-page post-status-publish locale-en-us", paste_as_text: true, paste_auto_cleanup_on_paste: true, paste_remove_spans: true, paste_remove_styles: true, paste_remove_styles_if_webkit: true, paste_strip_class_attributes: true } },
            qtInit: {},
            ref: { plugins: "charmap,colorpicker,hr,lists,media,paste,tabfocus,textcolor,fullscreen,wordpress,wpautoresize,wpeditimage,wpemoji,wpgallery,wplink,wpdialogs,wptextpattern,wpview,wpembed,image", theme: "modern", language: "en" },
            load_ext: function (url, lang) { var sl = tinymce.ScriptLoader; sl.markDone(url + '/langs/' + lang + '.js'); sl.markDone(url + '/langs/' + lang + '_dlg.js'); }
        };
    </script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/tinymce/tinymce.min.js?ver=4310-20160418'></script>
    <script type='text/javascript' src='http://alexgurghis.com/themes/jobsdojo/wp-includes/js/tinymce/plugins/compat3x/plugin.min.js?ver=4310-20160418'></script>
    <script type='text/javascript'>
        tinymce.addI18n('en', { "Ok": "OK", "Bullet list": "Bulleted list", "Spellcheck": "Check Spelling", "Row properties": "Table row properties", "Cell properties": "Table cell properties", "Paste row before": "Paste table row before", "Paste row after": "Paste table row after", "Cut row": "Cut table row", "Copy row": "Copy table row", "Merge cells": "Merge table cells", "Split cell": "Split table cell", "Paste is now in plain text mode. Contents will now be pasted as plain text until you toggle this option off.": "Paste is now in plain text mode. Contents will now be pasted as plain text until you toggle this option off.\n\nIf you\u2019re looking to paste rich content from Microsoft Word, try turning this option off. The editor will clean up text pasted from Word automatically.", "Rich Text Area. Press ALT-F9 for menu. Press ALT-F10 for toolbar. Press ALT-0 for help": "Rich Text Area. Press Alt-Shift-H for help", "You have unsaved changes are you sure you want to navigate away?": "The changes you made will be lost if you navigate away from this page.", "Your browser doesn't support direct access to the clipboard. Please use the Ctrl+X\/C\/V keyboard shortcuts instead.": "Your browser does not support direct access to the clipboard. Please use keyboard shortcuts or your browser\u2019s edit menu instead.", "Edit ": "Edit" });
        tinymce.ScriptLoader.markDone('http://alexgurghis.com/themes/jobsdojo/wp-includes/js/tinymce/langs/en.js');
    </script>
    <script type="text/javascript">
        var ajaxurl = "/themes/jobsdojo/wp-admin/admin-ajax.php";
        (function () {
            var init, id, $wrap;

            if (typeof tinymce !== 'undefined') {
                for (id in tinyMCEPreInit.mceInit) {
                    init = tinyMCEPreInit.mceInit[id];
                    $wrap = tinymce.$('#wp-' + id + '-wrap');

                    if (($wrap.hasClass('tmce-active') || !tinyMCEPreInit.qtInit.hasOwnProperty(id)) && !init.wp_skip_init) {
                        tinymce.init(init);

                        if (!window.wpActiveEditor) {
                            window.wpActiveEditor = id;
                        }
                    }
                }
            }

            if (typeof quicktags !== 'undefined') {
                for (id in tinyMCEPreInit.qtInit) {
                    quicktags(tinyMCEPreInit.qtInit[id]);

                    if (!window.wpActiveEditor) {
                        window.wpActiveEditor = id;
                    }
                }
            }
        }());
    </script>

</body>
</html>

