namespace Streams
{
    partial class FrmStreamWriter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            txtInput = new TextBox();
            btnClose = new Button();
            btnFlush = new Button();
            Write = new Button();
            btnWriteLine = new Button();
            btnReadLine = new Button();
            Read = new Button();
            btnReadToEnd = new Button();
            btnPeek = new Button();
            btnSeek = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(579, 23);
            txtInput.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 41);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 31);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnCreate_Click;
            // 
            // btnFlush
            // 
            btnFlush.Location = new Point(129, 41);
            btnFlush.Name = "btnFlush";
            btnFlush.Size = new Size(111, 31);
            btnFlush.TabIndex = 3;
            btnFlush.Text = "Flush";
            btnFlush.UseVisualStyleBackColor = true;
            btnFlush.Click += btnFlush_Click;
            // 
            // Write
            // 
            Write.Location = new Point(246, 41);
            Write.Name = "Write";
            Write.Size = new Size(111, 31);
            Write.TabIndex = 4;
            Write.Text = "Write";
            Write.UseVisualStyleBackColor = true;
            Write.Click += Write_Click;
            // 
            // btnWriteLine
            // 
            btnWriteLine.Location = new Point(363, 41);
            btnWriteLine.Name = "btnWriteLine";
            btnWriteLine.Size = new Size(111, 31);
            btnWriteLine.TabIndex = 5;
            btnWriteLine.Text = "WriteLine";
            btnWriteLine.UseVisualStyleBackColor = true;
            btnWriteLine.Click += btnWriteLine_Click;
            // 
            // btnReadLine
            // 
            btnReadLine.Location = new Point(480, 41);
            btnReadLine.Name = "btnReadLine";
            btnReadLine.Size = new Size(111, 31);
            btnReadLine.TabIndex = 6;
            btnReadLine.Text = "ReadLine";
            btnReadLine.UseVisualStyleBackColor = true;
            btnReadLine.Click += btnReadLine_Click;
            // 
            // Read
            // 
            Read.Location = new Point(12, 78);
            Read.Name = "Read";
            Read.Size = new Size(111, 31);
            Read.TabIndex = 7;
            Read.Text = "Read";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // btnReadToEnd
            // 
            btnReadToEnd.Location = new Point(129, 78);
            btnReadToEnd.Name = "btnReadToEnd";
            btnReadToEnd.Size = new Size(111, 31);
            btnReadToEnd.TabIndex = 8;
            btnReadToEnd.Text = "ReadToEnd";
            btnReadToEnd.UseVisualStyleBackColor = true;
            btnReadToEnd.Click += btnReadToEnd_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(246, 78);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(111, 31);
            btnPeek.TabIndex = 9;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnSeek
            // 
            btnSeek.Location = new Point(363, 78);
            btnSeek.Name = "btnSeek";
            btnSeek.Size = new Size(111, 31);
            btnSeek.TabIndex = 10;
            btnSeek.Text = "Seek";
            btnSeek.UseVisualStyleBackColor = true;
            btnSeek.Click += btnSeek_Click;
            // 
            // FrmStreamWriter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 173);
            Controls.Add(btnSeek);
            Controls.Add(btnPeek);
            Controls.Add(btnReadToEnd);
            Controls.Add(Read);
            Controls.Add(btnReadLine);
            Controls.Add(btnWriteLine);
            Controls.Add(Write);
            Controls.Add(btnFlush);
            Controls.Add(btnClose);
            Controls.Add(txtInput);
            Name = "FrmStreamWriter";
            Text = "FrmStreamWriter";
            Load += FrmStreamWriter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnClose;
        private Button btnFlush;
        private Button Write;
        private Button btnWriteLine;
        private Button btnReadLine;
        private Button Read;
        private Button btnReadToEnd;
        private Button btnPeek;
        private Button btnSeek;
    }
}