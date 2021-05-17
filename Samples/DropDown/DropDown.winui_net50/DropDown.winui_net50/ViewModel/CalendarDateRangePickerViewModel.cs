using Microsoft.UI.Xaml.Controls.Primitives;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropDown
{
    class CalerdarDateRangePickerViewModel : NotificationObject
    {
        private int dropDownHeight = 300;
        private bool showDropDownButton = true;
        private bool showSubmitButtons = true;
        private FlyoutPlacementMode dropDownPlacement = FlyoutPlacementMode.BottomEdgeAlignedRight;

        public FlyoutPlacementMode DropDownPlacement
        {
            get
            {
                return dropDownPlacement;
            }
            set
            {
                if (dropDownPlacement != value)
                {
                    dropDownPlacement = value;
                    this.RaisePropertyChanged(nameof(this.DropDownPlacement));
                }
            }
        }

        public bool ShowDropDownButton
        {
            get
            {
                return showDropDownButton;
            }
            set
            {
                if (showDropDownButton != value)
                {
                    showDropDownButton = value;
                    this.RaisePropertyChanged(nameof(this.ShowDropDownButton));
                }
            }
        }
        public bool ShowSubmitButtons
        {
            get
            {
                return showSubmitButtons;
            }
            set
            {
                if (showSubmitButtons != value)
                {
                    showSubmitButtons = value;
                    this.RaisePropertyChanged(nameof(this.ShowSubmitButtons));
                }
            }
        }

        public int DropDownHeight
        {
            get
            {
                return dropDownHeight;
            }
            set
            {
                if (dropDownHeight != value)
                {
                    dropDownHeight = value;
                    this.RaisePropertyChanged(nameof(this.DropDownHeight));
                }
            }
        }
    }
}
