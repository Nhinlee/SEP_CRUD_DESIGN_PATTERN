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
    using SEP_CRUD_DesignPattern.DB;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class EditFormDesignerTemplate : EditFormDesignerTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\nnamespace ");
            
            #line 8 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    partial class ");
            
            #line 10 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.Name));
            
            #line default
            #line hidden
            this.Write(@"
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name=""disposing"">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			// Labels & Components Creation
			this.components = new System.ComponentModel.Container();
			");
            
            #line 40 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
 

			WriteLine("");

			var t = generator.Table;
			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine($"			this.label{i+1} = new System.Windows.Forms.Label();");
			}
			
			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine($"			this.textBox{t.Columns[i].Name} = new System.Windows.Forms.TextBox();");
			}
			
			
            
            #line default
            #line hidden
            this.Write("\t\t\tthis.bindingSourceEditForm = new System.Windows.Forms.BindingSource(this.compo" +
                    "nents);\r\n            ((System.ComponentModel.ISupportInitialize)(this.bindingSou" +
                    "rceEditForm)).BeginInit();\r\n\r\n            this.SuspendLayout();\r\n\t\t\t// Design UI" +
                    "\r\n\t\t\t\r\n\t\t\t");
            
            #line 62 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
 

			WriteLine("");

			float posY = 50;
			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine("					//");
				WriteLine($"				// label{i+1}");
				WriteLine($"				//");
				WriteLine($"				label{i+1}.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);");
				WriteLine($"				label{i+1}.AutoSize = true;");
				WriteLine($"				label{i+1}.Location = new System.Drawing.Point(30, {posY});");
				WriteLine($"				label{i+1}.Name = \"label{i+1}\";");
				WriteLine($"				label{i+1}.Size = new System.Drawing.Size(60, 20);");
				WriteLine($"				label{i+1}.TabIndex = 1;");
				WriteLine($"				label{i+1}.Text = \"{t.Columns[i].Name}\";");
				//
				posY += 60;
			}

			posY = 50;
			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine("					//");
				WriteLine($"				// textBox{t.Columns[i].Name}");
				WriteLine($"				//");
				WriteLine($"				this.textBox{t.Columns[i].Name}.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);");
				WriteLine($"				this.textBox{t.Columns[i].Name}.Location = new System.Drawing.Point(100, {posY});");
				WriteLine($"				this.textBox{t.Columns[i].Name}.Name = \"textBox{t.Columns[i].Name}\";");
				WriteLine($"				this.textBox{t.Columns[i].Name}.Size = new System.Drawing.Size(130, 20);");
				WriteLine($"				this.textBox{t.Columns[i].Name}.TabIndex = 1;");
				//
				posY += 60;
			}
			

			// 
			//	Add into Controls
			//
			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine($"				this.Controls.Add(this.textBox{t.Columns[i].Name});");
			}

			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine($"				this.Controls.Add(this.label{i+1});");
			}
			
			
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t// \r\n            // btnSave\r\n            // \r\n\t\t\tthis.btnSave = new System.W" +
                    "indows.Forms.Button();\r\n            this.btnSave.Location = new System.Drawing.P" +
                    "oint(100, ");
            
            #line 118 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(posY));
            
            #line default
            #line hidden
            this.Write(@");
            this.btnSave.Name = ""btnSave"";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = ""Save"";
            this.btnSave.UseVisualStyleBackColor = true;
			//
			this.Controls.Add(this.btnSave);

            // 
            // EditFormSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(280, ");
            
            #line 131 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(posY + 50));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t\r\n\t\t\t\r\n            this.Name = \"");
            
            #line 134 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n            this.Text = \"");
            
            #line 135 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\t((System.ComponentModel.ISupportInitialize)(this.bindingSourceEditForm)).E" +
                    "ndInit();\r\n            this.ResumeLayout(false);\r\n            this.PerformLayout" +
                    "();\r\n\r\n        }\r\n\r\n        #endregion\r\n\t\t");
            
            #line 143 "E:\CS\sep_crup_design_pattern\SEP_CRUD_DesignPattern\SEP_CRUD_DesignPattern\Templates\Forms\EditFormDesignerTemplate.tt"
 

			WriteLine("");

			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine($"		private System.Windows.Forms.Label label{i+1};");
			}

			for(int i=0; i < t.Columns.Count; i++)
			{
				WriteLine($"		private System.Windows.Forms.TextBox textBox{t.Columns[i].Name};");
			}
			
		
            
            #line default
            #line hidden
            this.Write("\t\tprivate System.Windows.Forms.BindingSource bindingSourceEditForm;\r\n\t\tprivate Sy" +
                    "stem.Windows.Forms.Button btnSave;\r\n    }\r\n}\r\n");
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
    public class EditFormDesignerTemplateBase
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
