﻿namespace Param_ItemNamespace.ViewModels
{
    public class wts.ItemNameViewModel : ViewModelBase
    {
        //^^

        //{[{
        public override void Cleanup()
        {
            if (locationService != null)
            {
                locationService.PositionChanged -= LocationService_PositionChanged;
                locationService.StopListening();
            }

            base.Cleanup();
        }
        //}]}
    }
}
