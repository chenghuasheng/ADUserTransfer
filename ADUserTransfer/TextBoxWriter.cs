﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADUserTransfer
{
    class TextBoxWriter: TextWriter
    {
        TextBox textBox;
        delegate void WriteFunc(string value);

        private WriteFunc write;
        private WriteFunc writeLine;

        private int maxLines = 30000;
        public int MaxLines
        {
            get => maxLines;
            set => maxLines = value;
        }
        public TextBoxWriter(TextBox textBox)
        {
            this.textBox = textBox;
            write = Write;
            writeLine = WriteLine;
        }

        // 使用UTF-16避免不必要的编码转换
        public override Encoding Encoding
        {
            get { return Encoding.Unicode; }
        }


        // 最低限度需要重写的方法
        public override void Write(string value)
        {
            if (textBox.InvokeRequired)
                textBox.BeginInvoke(write, value);
            else
                textBox.AppendText(value);
        }


        // 为提高效率直接处理一行的输出
        public override void WriteLine(string value)
        {
            if (textBox.InvokeRequired)
                textBox.BeginInvoke(writeLine, value);
            else
            {
                textBox.AppendText(value);
                textBox.AppendText(this.NewLine);
                if (this.textBox.Lines.Length >= maxLines)
                {
                    this.textBox.Lines = this.textBox.Lines.Skip(maxLines/2).ToArray();
                }
            }
        }
    }
}
