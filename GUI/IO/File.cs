using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace InterfaceGUI.IO
{
    class File
    {
        public enum OPEN_TYPE
        {
            READING,
            WRITING,
            APPEND
        }

        private String Path;
        private Byte[] Data;
        private bool Success;

        public File(String fileName, OPEN_TYPE Type, Byte[] Data)
        {
            this.Success = false;
            this.Path = fileName;

            if (Type == OPEN_TYPE.READING)
                if (this.Open())
                    this.Success = true;

            if (Type == OPEN_TYPE.WRITING)
            {
                this.Data = Data;
                if (this.Write())
                    Success = true;
            }
            
            if (Type == OPEN_TYPE.APPEND)
            {
                if (this.openAppend())
                    Success = true;
            }   
        }

        private bool Open()
        {
            if (!System.IO.File.Exists(this.Path))
                return false;
            try
            {
                FileStream FS = System.IO.File.OpenRead(this.Path);

                if (FS.Length > int.MaxValue) // we don't want to try to down cast if so
                    return false;

                this.Data = new Byte[(int)FS.Length];
                FS.Read(Data, 0, (int)FS.Length);
                FS.Close();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        private bool Write()
        {
            try
            {
                FileStream FS = System.IO.File.Create(this.Path);
                FS.Write(this.Data, 0, this.Data.Length);
                FS.Close();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }

        private bool openAppend()
        {
            return this.Open();
        }

        public bool writeAppend(Byte[] newData)
        {
            if (this.Data != null)
            {
                Byte[] Buff = new Byte[newData.Length + this.Data.Length];
                Buffer.BlockCopy(Data, 0, Buff, 0, Data.Length);
                Buffer.BlockCopy(newData, 0, Buff, Data.Length, newData.Length);

                this.Data = Buff;
            }

            else
                this.Data = newData;

            return this.Write();
        }

        public bool Valid()
        {
            return this.Success;
        }
    }
}
