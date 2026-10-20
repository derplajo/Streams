namespace Streams
{
    partial class FrmFileStream
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
            btnCreate = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnReadByte = new Button();
            btnRead = new Button();
            btnWriteByte = new Button();
            btnWrite = new Button();
            btnFlush = new Button();
            btnCanRead = new Button();
            btnCanSeek = new Button();
            btnCanTimeout = new Button();
            btnCanWrite = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(579, 23);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 50);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 31);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(129, 50);
            button2.Name = "button2";
            button2.Size = new Size(111, 31);
            button2.TabIndex = 2;
            button2.Text = "CreateNew";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(246, 50);
            button3.Name = "button3";
            button3.Size = new Size(111, 31);
            button3.TabIndex = 3;
            button3.Text = "Open";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(363, 50);
            button4.Name = "button4";
            button4.Size = new Size(111, 31);
            button4.TabIndex = 4;
            button4.Text = "OpenOrCreate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(480, 50);
            button5.Name = "button5";
            button5.Size = new Size(111, 31);
            button5.TabIndex = 5;
            button5.Text = "Truncate";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnReadByte
            // 
            btnReadByte.Location = new Point(12, 87);
            btnReadByte.Name = "btnReadByte";
            btnReadByte.Size = new Size(111, 31);
            btnReadByte.TabIndex = 6;
            btnReadByte.Text = "ReadByte";
            btnReadByte.UseVisualStyleBackColor = true;
            btnReadByte.Click += btnReadByte_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(129, 87);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(111, 31);
            btnRead.TabIndex = 7;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWriteByte
            // 
            btnWriteByte.Location = new Point(246, 87);
            btnWriteByte.Name = "btnWriteByte";
            btnWriteByte.Size = new Size(111, 31);
            btnWriteByte.TabIndex = 8;
            btnWriteByte.Text = "WriteByte";
            btnWriteByte.UseVisualStyleBackColor = true;
            btnWriteByte.Click += btnWriteByte_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(363, 87);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(111, 31);
            btnWrite.TabIndex = 9;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnFlush
            // 
            btnFlush.Location = new Point(480, 87);
            btnFlush.Name = "btnFlush";
            btnFlush.Size = new Size(111, 31);
            btnFlush.TabIndex = 10;
            btnFlush.Text = "Flush";
            btnFlush.UseVisualStyleBackColor = true;
            btnFlush.Click += btnFlush_Click;
            // 
            // btnCanRead
            // 
            btnCanRead.Location = new Point(12, 124);
            btnCanRead.Name = "btnCanRead";
            btnCanRead.Size = new Size(111, 31);
            btnCanRead.TabIndex = 11;
            btnCanRead.Text = "CanRead";
            btnCanRead.UseVisualStyleBackColor = true;
            btnCanRead.Click += btnCanRead_Click;
            // 
            // btnCanSeek
            // 
            btnCanSeek.Location = new Point(129, 124);
            btnCanSeek.Name = "btnCanSeek";
            btnCanSeek.Size = new Size(111, 31);
            btnCanSeek.TabIndex = 12;
            btnCanSeek.Text = "CanSeek";
            btnCanSeek.UseVisualStyleBackColor = true;
            btnCanSeek.Click += btnCanSeek_Click;
            // 
            // btnCanTimeout
            // 
            btnCanTimeout.Location = new Point(246, 124);
            btnCanTimeout.Name = "btnCanTimeout";
            btnCanTimeout.Size = new Size(111, 31);
            btnCanTimeout.TabIndex = 13;
            btnCanTimeout.Text = "CanTimeout";
            btnCanTimeout.UseVisualStyleBackColor = true;
            btnCanTimeout.Click += btnCanTimeout_Click;
            // 
            // btnCanWrite
            // 
            btnCanWrite.Location = new Point(363, 124);
            btnCanWrite.Name = "btnCanWrite";
            btnCanWrite.Size = new Size(111, 31);
            btnCanWrite.TabIndex = 14;
            btnCanWrite.Text = "CanWrite";
            btnCanWrite.UseVisualStyleBackColor = true;
            btnCanWrite.Click += btnCanWrite_Click;
            // 
            // FrmFileStream
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 168);
            Controls.Add(btnCanWrite);
            Controls.Add(btnCanTimeout);
            Controls.Add(btnCanSeek);
            Controls.Add(btnCanRead);
            Controls.Add(btnFlush);
            Controls.Add(btnWrite);
            Controls.Add(btnWriteByte);
            Controls.Add(btnRead);
            Controls.Add(btnReadByte);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "FrmFileStream";
            Text = "FrmFileStream";
            Load += FrmFileStream_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCreate;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btnReadByte;
        private Button btnRead;
        private Button btnWriteByte;
        private Button btnWrite;
        private Button btnFlush;
        private Button btnCanRead;
        private Button btnCanSeek;
        private Button btnCanTimeout;
        private Button btnCanWrite;
    }
}