using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using NetFwTypeLib;
using _;

namespace _
{
    public partial class _ : Form
    {
        private readonly Status __ = new Status();

        public static void ___()
        {
            Console.WriteLine("Active TCP Connections");
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();
            foreach (TcpConnectionInformation c in connections)
            {
                Console.WriteLine("{0} <==> {1}",
                    c.LocalEndPoint.ToString(),
                    c.RemoteEndPoint.ToString());
            }
        }

        public _()
        {
            _____();
            ______.CellValueChanged += ________;
            ______.CellContentClick += ____________;
            ______.CellClick += _____________;
            ______.AutoSize = true;
            ________________();
        }

        private void _____________(object _, DataGridViewCellEventArgs ___)
        {
            if (___.ColumnIndex == -1 || ___.RowIndex == -1) return;
            DataGridViewCell cell = (______.Rows[___.RowIndex].Cells[___.ColumnIndex]);
            if (___.ColumnIndex != 3) return;
            var __ = new OpenFileDialog { Filter = @"Application|*.exe;*.msi;*.com", Multiselect = !true };
            if (__.ShowDialog(this) == DialogResult.OK)
                cell.Value = __.FileName;
        }

        private DataGridViewRow _________()
        {
            //foreach (DataGridViewRow row in Explorer.Rows)
            //    if (row.IsNewRow)
            //    {
            //        var l = Explorer.Rows.Add(1);
            //        return row;
            //    }
            return ______.Rows[______.Rows.Add(1)];
        }

        private void ____________(object _, DataGridViewCellEventArgs __)
        {
            if (__.ColumnIndex == -1 || __.RowIndex == -1) return;
            var ____ = (______.Rows[__.RowIndex].Cells[__.ColumnIndex]);
            if (__.ColumnIndex != 7) return;
            var ___ = (string)____.Value;
            ____.Value = ___ == "NotSet" ? "Add" : ___ == "Add" ? "Remove" : "NotSet";
        }

        private void ____(FileSystemInfo rule, bool markAsNew)
        {
            if (!rule.Exists) return;
            var r = new _____________________________(______, _________(), __)
            {
                ______ = markAsNew,
                ____________ = rule.Name,
                ______________ = rule.FullName,
                __________ = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT,
            };
            r._________________();
        }

        private void ________(object sender, DataGridViewCellEventArgs e)
        {
            if (__._ == true) return;

            if (e.ColumnIndex == 5)
            {
                var _in = ______.Rows[e.RowIndex].Cells[5];
                var _out = ______.Rows[e.RowIndex].Cells[6];
                if (_____________________________.__________________(_out.Value) == _____________________________.__________________(_in.Value) && _____________________________.__________________(_in.Value) == false)
                {
                    __._.Push(true);
                    _in.Value = true;
                    __._.Pop();
                }
            }
            if (e.ColumnIndex == 6)
            {
                var _in = ______.Rows[e.RowIndex].Cells[5];
                var _out = ______.Rows[e.RowIndex].Cells[6];
                if (_____________________________.__________________(_out.Value) == _____________________________.__________________(_in.Value) && _____________________________.__________________(_in.Value) == false)
                {
                    __._.Push(true);
                    _out.Value = true;
                    __._.Pop();
                }
            }
            DataGridViewRow t = ______.Rows[e.RowIndex];
            var value = (string)t.Cells["id"].Value;
            if (value == null)
                (new _____________________________(______, t, __)).______________________();
            else
                _____________________________.__________________(value).______________________();
        }

        private void ____(_____________________________ rule)
        {
            if (__._ == true) return;
            rule._________________();
        }

        private bool _______(string path)
        {
            foreach (DataGridViewRow row in ______.Rows)
                if ((string)row.Cells["Path"].Value == path) return true;
            return false;
        }

        private void __________(object __, EventArgs ___)
        {
            Process[] _ = Process.GetProcesses();
            foreach (var _____ in _)
            {

                string _______ = null;
                try
                {
                    _______ = _____.MainModule.FileName;
                }
                catch (Exception)
                {
                }
                if (!string.IsNullOrEmpty(_______) && !this._______(_______))
                    ____(new _____________________________(______, _________(), this.__, _____));
            }
        }

        private void ________________(object _, EventArgs __)
        {
            var ___ = new OpenFileDialog { Filter = @"Application|*.exe;*.msi;*.com", Multiselect = true };
            if (___.ShowDialog(this) == DialogResult.OK)
                foreach (var _____ in ___.FileNames)
                    ____(new FileInfo(_____), true);
        }

        private void Apply_Click(object _____, EventArgs _________)
        {
            foreach (DataGridViewRow _ in ______.Rows)
            {
                var __ = (string)_.Cells[8].Value;
                var ___ = _____________________________.__________________(__);
                if (___ == null) continue;
                if ((string)_.Cells["Strategy"].Value == "NotSet") continue;
                _a._______(___);
            }
        }

        public new _____________________________ ________________(INetFwRule _)
        {
            //IPAddress[] hostAddresses = Dns.GetHostAddresses("www.google.com");
            var __ = _.Name.LastIndexOf(global::_.______.___, StringComparison.Ordinal);
            var ___ = _.Name.Substring(__ + global::_.______.___.Length);
            var ____ = _____________________________._________________(___);
            var _____ = ____ == null;
            if (____ == null)
                ____ = new _____________________________(______, _________(),this. __)
                {
                    ______ = false,
                    ____________ = ___,
                    ______________ = _.ApplicationName,
                    _ = global::_.______________________________________.___,
                    ________________ = _.Action == NET_FW_ACTION_.NET_FW_ACTION_BLOCK
                };
            ____.__________ = _____ ? _.Direction : _.Direction | ____.__________;
            if (_.Direction == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN)
                ____.________ = _;
            else ____._________ = _;
            ____._________________();
            return ____;
        }

        public void ________________()
        {
            foreach (var c in _a.____.Select(________________))
            {
            }
        }

        private readonly ______ _a = new ______();
    }
}

namespace System.Net.NetworkInformation
{
    internal class _ : TcpConnectionInformation
    {
        private IPEndPoint __;
        private IPEndPoint ___;
        private TcpState ____;

        public override TcpState State
        {
            get
            {
                return this.____;
            }
        }

        public override IPEndPoint LocalEndPoint
        {
            get
            {
                return this.__;
            }
        }

        public override IPEndPoint RemoteEndPoint
        {
            get
            {
                return this.___;
            }
        }

        internal _(__________________ _)
        {
            this.____ = _.________;
            var __ = _._ << 24 | _._______________ << 16 | _.___ << 8 | _.____;
            var ___ = this.____ == TcpState.Listen ? 0 : _._______ << 24 | _._____ << 16 | _.____________ << 8 | _.__________;
            this.__ = new IPEndPoint(_.__, __);
            this.___ = new IPEndPoint(_._____________, ___);
        }
    }
}