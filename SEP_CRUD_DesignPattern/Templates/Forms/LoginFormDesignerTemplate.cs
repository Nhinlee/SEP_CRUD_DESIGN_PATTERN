﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SEP_CRUD_DesignPattern.Templates.Forms
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\LoginFormDesignerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class LoginFormDesignerTemplate : LoginFormDesignerTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nnamespace ");
            
            #line 7 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\LoginFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    partial class ");
            
            #line 9 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\LoginFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.Name));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        /// <summary>\r\n        /// Required designer variable.\r\n        " +
                    "/// </summary>\r\n        private System.ComponentModel.IContainer components = nu" +
                    "ll;\r\n\r\n        /// <summary>\r\n        /// Clean up any resources being used.\r\n  " +
                    "      /// </summary>\r\n        /// <param name=\"disposing\">true if managed resour" +
                    "ces should be disposed; otherwise, false.</param>\r\n        protected override vo" +
                    "id Dispose(bool disposing)\r\n        {\r\n            if (disposing && (components " +
                    "!= null))\r\n            {\r\n                components.Dispose();\r\n            }\r\n" +
                    "            base.Dispose(disposing);\r\n        }\r\n\r\n        #region Windows Form " +
                    "Designer generated code\r\n\r\n        /// <summary>\r\n        /// Required method fo" +
                    "r Designer support - do not modify\r\n        /// the contents of this method with" +
                    " the code editor.\r\n        /// </summary>\r\n        private void InitializeCompon" +
                    "ent()\r\n        {\r\n            this.components = new System.ComponentModel.Contai" +
                    "ner();\r\n            this.tbServerName = new System.Windows.Forms.TextBox();\r\n   " +
                    "         this.btnCancel = new System.Windows.Forms.Button();\r\n            this.b" +
                    "tnConnect = new System.Windows.Forms.Button();\r\n            this.lbPassword = ne" +
                    "w System.Windows.Forms.Label();\r\n            this.tbPassword = new System.Window" +
                    "s.Forms.TextBox();\r\n            this.tbUserName = new System.Windows.Forms.TextB" +
                    "ox();\r\n            this.lbUser = new System.Windows.Forms.Label();\r\n            " +
                    "this.lbServerName = new System.Windows.Forms.Label();\r\n            this.bindingS" +
                    "ourceLoginDB = new System.Windows.Forms.BindingSource(this.components);\r\n       " +
                    "     ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoginDB)).Beg" +
                    "inInit();\r\n            this.SuspendLayout();\r\n            // \r\n            // tb" +
                    "ServerName\r\n            // \r\n            this.tbServerName.Location = new System" +
                    ".Drawing.Point(204, 75);\r\n            this.tbServerName.Name = \"tbServerName\";\r\n" +
                    "            this.tbServerName.Size = new System.Drawing.Size(309, 22);\r\n        " +
                    "    this.tbServerName.TabIndex = 22;\r\n            // \r\n            // btnCancel\r" +
                    "\n            // \r\n            this.btnCancel.Location = new System.Drawing.Point" +
                    "(408, 382);\r\n            this.btnCancel.Name = \"btnCancel\";\r\n            this.bt" +
                    "nCancel.Size = new System.Drawing.Size(105, 34);\r\n            this.btnCancel.Tab" +
                    "Index = 21;\r\n            this.btnCancel.Text = \"Cancel\";\r\n            this.btnCa" +
                    "ncel.UseVisualStyleBackColor = true;\r\n            // \r\n            // btnConnect" +
                    "\r\n            // \r\n            this.btnConnect.Location = new System.Drawing.Poi" +
                    "nt(246, 382);\r\n            this.btnConnect.Name = \"btnConnect\";\r\n            thi" +
                    "s.btnConnect.Size = new System.Drawing.Size(107, 34);\r\n            this.btnConne" +
                    "ct.TabIndex = 20;\r\n            this.btnConnect.Text = \"Connect\";\r\n            th" +
                    "is.btnConnect.UseVisualStyleBackColor = true;\r\n            // \r\n            // l" +
                    "bPassword\r\n            // \r\n            this.lbPassword.AutoSize = true;\r\n      " +
                    "      this.lbPassword.Location = new System.Drawing.Point(72, 179);\r\n           " +
                    " this.lbPassword.Name = \"lbPassword\";\r\n            this.lbPassword.Size = new Sy" +
                    "stem.Drawing.Size(73, 17);\r\n            this.lbPassword.TabIndex = 16;\r\n        " +
                    "    this.lbPassword.Text = \"Password:\";\r\n            // \r\n            // tbPassw" +
                    "ord\r\n            // \r\n            this.tbPassword.Location = new System.Drawing." +
                    "Point(204, 176);\r\n            this.tbPassword.Name = \"tbPassword\";\r\n            " +
                    "this.tbPassword.Size = new System.Drawing.Size(309, 22);\r\n            this.tbPas" +
                    "sword.TabIndex = 15;\r\n            // \r\n            // tbUserName\r\n            //" +
                    " \r\n            this.tbUserName.Location = new System.Drawing.Point(204, 123);\r\n " +
                    "           this.tbUserName.Name = \"tbUserName\";\r\n            this.tbUserName.Siz" +
                    "e = new System.Drawing.Size(309, 22);\r\n            this.tbUserName.TabIndex = 14" +
                    ";\r\n            // \r\n            // lbUser\r\n            // \r\n            this.lbU" +
                    "ser.AutoSize = true;\r\n            this.lbUser.Location = new System.Drawing.Poin" +
                    "t(72, 126);\r\n            this.lbUser.Name = \"lbUser\";\r\n            this.lbUser.S" +
                    "ize = new System.Drawing.Size(42, 17);\r\n            this.lbUser.TabIndex = 13;\r\n" +
                    "            this.lbUser.Text = \"User:\";\r\n            // \r\n            // lbServe" +
                    "rName\r\n            // \r\n            this.lbServerName.AutoSize = true;\r\n        " +
                    "    this.lbServerName.Location = new System.Drawing.Point(60, 78);\r\n            " +
                    "this.lbServerName.Name = \"lbServerName\";\r\n            this.lbServerName.Size = n" +
                    "ew System.Drawing.Size(95, 17);\r\n            this.lbServerName.TabIndex = 12;\r\n " +
                    "           this.lbServerName.Text = \"Server Name:\";\r\n            // \r\n          " +
                    "  // LoginForm\r\n            // \r\n            this.AutoScaleDimensions = new Syst" +
                    "em.Drawing.SizeF(8F, 16F);\r\n            this.AutoScaleMode = System.Windows.Form" +
                    "s.AutoScaleMode.Font;\r\n            this.ClientSize = new System.Drawing.Size(586" +
                    ", 471);\r\n            this.Controls.Add(this.tbServerName);\r\n            this.Con" +
                    "trols.Add(this.btnCancel);\r\n            this.Controls.Add(this.btnConnect);\r\n   " +
                    "         this.Controls.Add(this.lbPassword);\r\n            this.Controls.Add(this" +
                    ".tbPassword);\r\n            this.Controls.Add(this.tbUserName);\r\n            this" +
                    ".Controls.Add(this.lbUser);\r\n            this.Controls.Add(this.lbServerName);\r\n" +
                    "            this.Name = \"LoginForm\";\r\n            this.Text = \"LoginForm\";\r\n    " +
                    "        ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoginDB))." +
                    "EndInit();\r\n            this.ResumeLayout(false);\r\n            this.PerformLayou" +
                    "t();\r\n\r\n        }\r\n\r\n        #endregion\r\n\r\n        private System.Windows.Forms." +
                    "TextBox tbServerName;\r\n        private System.Windows.Forms.Button btnCancel;\r\n " +
                    "       private System.Windows.Forms.Button btnConnect;\r\n        private System.W" +
                    "indows.Forms.Label lbPassword;\r\n        private System.Windows.Forms.TextBox tbP" +
                    "assword;\r\n        private System.Windows.Forms.TextBox tbUserName;\r\n        priv" +
                    "ate System.Windows.Forms.Label lbUser;\r\n        private System.Windows.Forms.Lab" +
                    "el lbServerName;\r\n        private System.Windows.Forms.BindingSource bindingSour" +
                    "ceLoginDB;\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class LoginFormDesignerTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
