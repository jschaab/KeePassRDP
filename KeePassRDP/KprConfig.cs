﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KeePass.App.Configuration;

namespace KeePassRDP
{
    public class KprConfig
    {
        private readonly AceCustomConfig _config;
        const string KeePassShowResolvedReferencesKey = "KPR_keepassShowResolvedReferences";
        const string MstscUseFullscreenKey = "KPR_mstscUseFullscreen";
        const string MstscUseAdminKey = "KPR_mstscUseAdmin";
        const string MstscUseSpanKey = "KPR_mstscUseSpan";
        const string MstscUseMultimonKey = "KPR_mstscUseMultimon";
        const string MstscWidthKey = "KPR_mstscWidth";
        const string MstscHeightKey = "KPR_mstscHeight";

        public KprConfig(AceCustomConfig config)
        {
            _config = config;
        }

        public bool KeePassShowResolvedReferences
        {
            get { return _config.GetBool(KeePassShowResolvedReferencesKey, true); }
            set { _config.SetBool(KeePassShowResolvedReferencesKey, value); }
        }

        public bool MstscUseFullscreen
        {
            get { return _config.GetBool(MstscUseFullscreenKey, false); }
            set { _config.SetBool(MstscUseFullscreenKey, value); }
        }

        public bool MstscUseAdmin
        {
            get { return _config.GetBool(MstscUseAdminKey, false); }
            set { _config.SetBool(MstscUseAdminKey, value); }
        }

        public bool MstscUseSpan
        {
            get { return _config.GetBool(MstscUseSpanKey, false); }
            set { _config.SetBool(MstscUseSpanKey, value); }
        }

        public bool MstscUseMultimon
        {
            get { return _config.GetBool(MstscUseMultimonKey, false); }
            set { _config.SetBool(MstscUseMultimonKey, value); }
        }

        public ulong MstscWidth
        {
            get { return _config.GetULong(MstscWidthKey, 0); }
            set { _config.SetULong(MstscWidthKey, value); }
        }

        public ulong MstscHeight
        {
            get { return _config.GetULong(MstscHeightKey, 0); }
            set { _config.SetULong(MstscHeightKey, value); }
        }
    }
}
