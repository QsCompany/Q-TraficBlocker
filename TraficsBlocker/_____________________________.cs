using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using NetFwTypeLib;

namespace _
{
    public class _____________________________
    {
        private readonly DataGridView __;
        private readonly Status ___;
        public readonly static Dictionary<string, _____________________________> ____ = new Dictionary<string, _____________________________>();
        public readonly string _____ = Guid.NewGuid().ToString();

        public bool ______
        {
            get { return _______; }
            set
            {
                _______ = value;
                ___._.Push(true);
                t.Cells[0].Value = value;
                ___._.Pop();
            }
        }

        public INetFwRule ________ { get; set; }
        public INetFwRule _________ { get; set; }
        public NET_FW_RULE_DIRECTION_ __________
        {
            get
            {
                return ___________;
            }
            set
            {
                if ((int) value < 1) value = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                else if ((int) value > 3) value = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_MAX;
                ___________ = value;
            }
        }

        public string ____________;
        public string ______________;
        public int _______________;
        public bool ________________;
        public NET_FW_RULE_DIRECTION_ ___________;
        public ______________________________________ _;
        public readonly DataGridViewRow t;
        private bool _______;

        public _____________________________(DataGridView _,DataGridViewRow __ ,Status ___, Process ____) : this(_, __,___)
        {
            ____________ = ____.ProcessName;
            try
            {
                ______________ = ____.MainModule.FileName;
            }
            catch (Exception)
            {
                ______________ = "";
            }
            
            _______________ = ____.Id;
            
        }

        public _____________________________(DataGridView _,DataGridViewRow __,Status ___)
        {
            t = __;
            this.__ = _;
            this.___ = ___;
            ___._.Push(true);
            __.Cells["id"].Value = _____;
            ___._.Pop();
            ____.Add(_____, this);
        }

        public static _____________________________ __________________(string _)
        {
            _____________________________ __;
            if (_ == null) return null;
            return ____.TryGetValue(_, out __) ? __ : null;
        }

        public DataGridViewRow _________________()
        {
            ___._.Push(true);
            t.Cells[0].Value = ______;
            t.Cells[1].Value = ____________;
            t.Cells[2].Value = _______________ == -1 ? null : _______________.ToString();
            t.Cells[3].Value = ______________;
            t.Cells[4].Value = ________________;
            t.Cells[5].Value = (__________ & NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN) ==
                               NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            t.Cells[6].Value = (__________ & NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT) ==
                               NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            t.Cells[7].Value = _ == ______________________________________._ ? "Add" : (_ == ______________________________________.__ ? "Remove" : "NotSet");
            ___._.Pop();
            return t;
        }

        public void ______________________()
        {
            ______ = __________________(t.Cells[0].Value);
            ____________ = (string) t.Cells[1].Value;
            _______________ = _________________(t.Cells[2].Value);
            ______________ = (string) t.Cells[3].Value;
            ________________ = __________________(t.Cells[4].Value);
            var IN = __________________(t.Cells[5].Value);
            var OUT = __________________(t.Cells[6].Value);

            __________ = IN
                ? NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN
                : 0;
            __________ = (OUT
                ? NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT
                : 0) | __________;
            var __ = t.Cells[7].Value as string;
            _ = __ == null ? ______________________________________._ : (__ == "Remove" ? ______________________________________.__ : ______________________________________._);
        }

        private int _________________(object _)
        {
            int __;
            return _ is int ? (int) _ : (_ is string && int.TryParse((string) _, out __) ? __ : -1);
        }

        public static bool __________________(object _)
        {
            return _ is bool && (bool) _;
        }

        public static _____________________________ _________________(string _)
        {
            foreach (var __ in ____)
                if (__.Value.____________ == _) return __.Value;
            return null;
        }
    }
}