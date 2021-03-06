﻿namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("BoardDbfRecord")]
    public class BoardDbfRecord : DbfRecord
    {
        public BoardDbfRecord(IntPtr address) : this(address, "BoardDbfRecord")
        {
        }

        public BoardDbfRecord(IntPtr address, string className) : base(address, className)
        {
        }

        public object GetVar(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<object>("GetVar", objArray1);
        }

        public System.Type GetVarType(string name)
        {
            object[] objArray1 = new object[] { name };
            return base.method_14<System.Type>("GetVarType", objArray1);
        }

        public void SetNoteDesc(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetNoteDesc", objArray1);
        }

        public void SetPrefab(string v)
        {
            object[] objArray1 = new object[] { v };
            base.method_8("SetPrefab", objArray1);
        }

        public void SetVar(string name, object val)
        {
            object[] objArray1 = new object[] { name, val };
            base.method_8("SetVar", objArray1);
        }

        public string m_NoteDesc
        {
            get
            {
                return base.method_4("m_NoteDesc");
            }
        }

        public string m_Prefab
        {
            get
            {
                return base.method_4("m_Prefab");
            }
        }

        public string NoteDesc
        {
            get
            {
                return base.method_13("get_NoteDesc", Array.Empty<object>());
            }
        }

        public string Prefab
        {
            get
            {
                return base.method_13("get_Prefab", Array.Empty<object>());
            }
        }
    }
}

