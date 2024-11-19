using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ancient.Town.Protection.Center.RNAncientTownProtectionCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAncientTownProtectionCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAncientTownProtectionCenterModule"/>.
        /// </summary>
        internal RNAncientTownProtectionCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAncientTownProtectionCenter";
            }
        }
    }
}
