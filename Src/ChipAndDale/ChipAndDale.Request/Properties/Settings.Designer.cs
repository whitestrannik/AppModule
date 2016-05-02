﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChipAndDale.Request.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Звернення")]
        public string RequestName {
            get {
                return ((string)(this["RequestName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("REQUEST")]
        public string RequestSection {
            get {
                return ((string)(this["RequestSection"]));
            }
            set {
                this["RequestSection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<html>\r\n<head>\r\n    <title>Intro</title>\r\n    <link rel=\"Stylesheet\" href=\"StyleS" +
            "heet\" />\r\n</head>\r\n<body style=\"background-color: #333; background-gradient: #70" +
            "7; background-gradient-angle: 60;\r\n    margin: 0;\">\r\n    <h1 align=\"center\" styl" +
            "e=\"color: white\">\r\n        HTML Renderer Project\r\n        <br />\r\n        <span " +
            "style=\"font-size: xx-small;\">Release 1.4.1.0</span>\r\n    </h1>\r\n    <blockquote " +
            "class=\"whitehole\">\r\n        <p style=\"margin-top: 0px\">\r\n            <table bord" +
            "er=\"0\" width=\"100%\">\r\n                <tr>\r\n                    <td width=\"32\" s" +
            "tyle=\"padding: 2px 5px 0 0\">\r\n                        <img src=\"HtmlIcon\" />\r\n  " +
            "                  </td>\r\n                    <td>\r\n                        Every" +
            "thing you see on this panel (see samples on the left) is <b>custom-painted</b>\r\n" +
            "                        by the HTML Renderer. Including tables, images, links an" +
            "d videos.<br />\r\n                        This project allows you can have the ri" +
            "ch format power of HTML on you desktop applications\r\n                        wit" +
            "hout <b>WebBrowser</b> control and <b>MSHTML</b>.<br />\r\n                       " +
            " The library is <b>100% managed code</b> without any external libraries dependen" +
            "cies,\r\n                        the only requirement is <b>.NET 2.0 or higher</b>" +
            ".\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n     " +
            "   </p>\r\n        <h3>\r\n            Text selection (copy-paste)\r\n        </h3>\r\n " +
            "       <div>\r\n            The rendered html has full support for <b>text selecti" +
            "on</b> including <b>drag-and-drop</b>\r\n            and <b>copy</b> to clipboard " +
            "of rich html and plain text to handle <b>paste</b>\r\n            operation to edi" +
            "tor that support rich or/and plain text.<br />\r\n            Addtionally there is" +
            " <b>context-menu</b> with select all, copy text, copy image,\r\n            save i" +
            "mage, open link, copy link url, open video, copy video url.\r\n        </div>\r\n   " +
            "     <h3>\r\n            Cascading Style Sheets (CSS) support\r\n        </h3>\r\n    " +
            "    <div>\r\n            The core layout engine of the renderer was builded accord" +
            "ing to <b>CSS Level 2 specification</b>,\r\n            so you can use Cascading S" +
            "tyle Sheets to format your html documents.<br />\r\n            Additionally there" +
            " are a couple extensions: <b>Gradients</b> on backgrounds and\r\n            <b>ro" +
            "unded corners</b>.\r\n        </div>\r\n        <h3>\r\n            WinForms support\r\n" +
            "        </h3>\r\n        <div>\r\n            It comes with handy WinForms controls " +
            "(see <a href=\"ShowSampleForm\">Sample Form</a>):\r\n        </div>\r\n        <ul>\r\n " +
            "           <li><code>HtmlPanel</code> - The control where you are reading this, " +
            "panel with scrollbars.</li>\r\n            <li><code>HtmlLabel</code> - Same as ht" +
            "ml panel but without scrollbars and optional\r\n                auto size.</li>\r\n " +
            "           <li><code>HtmlToolTip</code> - For ToolTip with rich html.</li>\r\n    " +
            "    </ul>\r\n        <h3>\r\n            Limitations\r\n        </h3>\r\n        <div>\r\n" +
            "            Here are some warnings that you should know when using the capabilit" +
            "ies of the HTML\r\n            Renderer:\r\n        </div>\r\n        <ul>\r\n          " +
            "  <li>All HTML <b>end tags</b> marked as <a href=\"http://www.w3.org/TR/1999/REC-" +
            "html401-19991224/index/elements.html\">\r\n                optional</a> should be t" +
            "here. No problem with tags marked as forbidden.</li>\r\n            <li>When using" +
            " rounded corners with borders, you must prevent the corner radius to be\r\n       " +
            "         larger than the border thickness</li>\r\n        </ul>\r\n        <hr />\r\n " +
            "       <h3>\r\n            On the roadmap</h3>\r\n        Of course it\'s not quite f" +
            "inished yet. Here are some of the important things to\r\n        do.\r\n        <ul>" +
            "\r\n            <li>Better performance</li>\r\n            <li>Support different bul" +
            "let types</li>\r\n            <li>Support of position CSS property</li>\r\n         " +
            "   <li>Support of height and min-height CSS property</li>\r\n            <li>Bette" +
            "r tables support, especially layouts</li>\r\n            <li>Support image align</" +
            "li>\r\n            <li>Support background image</li>\r\n            <li>Handle :hove" +
            "r selector</li>\r\n            <li>Selection by shift+arrows</li>\r\n            <li" +
            ">Better word wrap, not just whitespace</li>\r\n            <li>Support rtl using l" +
            "ang attribute</li>\r\n            <li>Better HTML tag parsing (optional closing ta" +
            "gs)</li>\r\n            <li>More styles support</li>\r\n        </ul>\r\n        <h3>\r" +
            "\n            Vision\r\n        </h3>\r\n        <ul>\r\n            <li>Most complete " +
            "static HTML Renderer (no java script).</li>\r\n            <li>Commercial web brow" +
            "ser performance level.</li>\r\n        </ul>\r\n        <hr />\r\n        <h3>\r\n      " +
            "      2012 - Arthur Teplitzki\r\n        </h3>\r\n        <blockquote>\r\n            " +
            "<a href=\"http://theartofdev.wordpress.com/\">http://TheArtOfDev.wordpress.com</a>" +
            "\r\n        </blockquote>\r\n        <h3>\r\n            2009 - Jose Manuel Menendez P" +
            "oo\r\n        </h3>\r\n        <blockquote>\r\n            <a href=\"http://www.menende" +
            "zpoo.com\">www.menendezpoo.com</a>\r\n        </blockquote>\r\n    </blockquote>\r\n</b" +
            "ody>\r\n</html>\r\n")]
        public string htmlstraing {
            get {
                return ((string)(this["htmlstraing"]));
            }
            set {
                this["htmlstraing"] = value;
            }
        }
    }
}