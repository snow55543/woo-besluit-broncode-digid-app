// Deze broncode is openbaar gemaakt vanwege een Woo-verzoek zodat deze 
// gericht is op transparantie en niet op hergebruik. Hergebruik van 
// de broncode is toegestaan onder de EUPL licentie, met uitzondering 
// van broncode waarvoor een andere licentie is aangegeven.
//
// Het archief waar dit bestand deel van uitmaakt is te vinden op:
//   https://github.com/MinBZK/woo-besluit-broncode-digid-app
//
// Eventuele kwetsbaarheden kunnen worden gemeld bij het NCSC via:
//   https://www.ncsc.nl/contact/kwetsbaarheid-melden
// onder vermelding van "Logius, openbaar gemaakte broncode DigiD-App" 
//
// Voor overige vragen over dit Woo-besluit kunt u mailen met open@logius.nl
//
// This code has been disclosed in response to a request under the Dutch
// Open Government Act ("Wet open Overheid"). This implies that publication 
// is primarily driven by the need for transparence, not re-use.
// Re-use is permitted under the EUPL-license, with the exception 
// of source files that contain a different license.
//
// The archive that this file originates from can be found at:
//   https://github.com/MinBZK/woo-besluit-broncode-digid-app
//
// Security vulnerabilities may be responsibly disclosed via the Dutch NCSC:
//   https://www.ncsc.nl/contact/kwetsbaarheid-melden
// using the reference "Logius, publicly disclosed source code DigiD-App" 
//
// Other questions regarding this Open Goverment Act decision may be
// directed via email to open@logius.nl
//
﻿using DigiD.Common.Helpers;
using DigiD.Common.Mobile.BaseClasses;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigiD.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivationRdaConfirmPage : BaseContentPage
    {
        public ActivationRdaConfirmPage()
        {
            InitializeComponent();
            SetAnimationSizes(DeviceDisplay.MainDisplayInfo.Orientation);
        }

        protected override void OrientationChanged(DisplayOrientation orientation)
        {
            base.OrientationChanged(orientation);
            SetAnimationSizes(orientation);
        }

        private void SetAnimationSizes(DisplayOrientation orientation)
        {
            if (Device.Idiom == TargetIdiom.Phone)
            {
                if (orientation == DisplayOrientation.Landscape)
                {
                    animationViewPortrait.HeightRequest = 0;
                    animationViewLandscape.HeightRequest = DisplayHelper.Height - 60;  // zie json "w":500, "h:500"
                }
                else
                {
                    animationViewPortrait.HeightRequest = DisplayHelper.Width - 40;  // zie json "w":500, "h:500"
                    animationViewLandscape.HeightRequest = 0;
                }
            }
            else
            {   // Tablet
                animationViewPortrait.HeightRequest = DisplayHelper.Height - 60;  // zie json "w":500, "h:500"
                animationViewLandscape.HeightRequest = 0;
            }
        }
    }
}