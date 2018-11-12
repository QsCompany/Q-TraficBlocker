using System;
using System.Collections.Generic;
using NetFwTypeLib;

namespace _
{
    class ______
    {
        public const string ___ = "_CSwitch: ";
        readonly INetFwPolicy2 __ = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
        public readonly List<INetFwRule> ____;

        public ______()
        {
            ____ = _();
        }
        public string _______(NET_FW_RULE_DIRECTION_ _ ,string ___)
        {
            return _ + ______.___ + ___;
        }
        public bool _______(_____________________________ __)
        {
            var _ = (int) __.__________;
            return
                _________(__, NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN,
                    (_ & 1) != 1 || __._ == ______________________________________.__) &
                _________(__, NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT,
                    (_ & 2) != 2 || __._ == ______________________________________.__);
        }

        private bool _________(_____________________________ _, NET_FW_RULE_DIRECTION_ __, bool ___)
        {
            try
            {
                var ____ = __ == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN
                    ? _.________
                    : _._________;

                var ______ = this._______(__, _.____________);
                if (___)
                {
                    this.__.Rules.Remove(______);
                    _.______ = true;
                }
                else
                {
                    var x = ____ ?? _______(______);
                    ____ = x ??
                                (INetFwRule) Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
                    ____.Action = _.________________
                        ? NET_FW_ACTION_.NET_FW_ACTION_BLOCK
                        : NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                    ____.Enabled = true;
                    ____.InterfaceTypes = "All";
                    ____.ApplicationName = _.______________;
                    ____.Direction = __;
                    if (x == null)
                    {
                        ____.Name = ______;
                        this.__.Rules.Add(____);
                        this.____.Add(____);
                    }
                    _.______ = false;
                    if (__ == NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN) _.________ = ____;
                    else _._________ = ____;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public INetFwRule _______(string a)
        {
            foreach (var __ in ____)
                if (__.Name == a) return __;
            return null;
        }

        public List<INetFwRule> _()
        {
            var e = new List<INetFwRule>();
            foreach (INetFwRule _ in __.Rules)
                if (_.Name.Contains(___)) e.Add(_);
            return e;
        }
    }
}