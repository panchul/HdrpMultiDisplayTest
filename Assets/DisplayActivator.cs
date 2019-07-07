using UnityEngine;

namespace Evp3
{
    sealed class DisplayActivator : MonoBehaviour
    {
        bool shouldActivateSecondDisplay {
            get {
                // The second display is not available on Editor.
                if (Application.isEditor) return false;

                // Check if the second display actually exists.
                if (Display.displays.Length < 1) return false;

                return true;
            }
        }

        void Start()
        {
            // WTF... https://answers.unity.com/questions/1428675/does-multi-display-work-on-mac-os-x.html
            if (shouldActivateSecondDisplay)
                Display.displays[1].Activate();
        }
    }
}
