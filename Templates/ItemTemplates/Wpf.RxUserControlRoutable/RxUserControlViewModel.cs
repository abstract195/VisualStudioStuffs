using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace $rootnamespace$
{
    public class $safeitemname$ : ReactiveObject, IRoutableViewModel, IActivatableViewModel, IDisposable
    {
		public $safeitemname$(IScreen screen)
        {
            HostScreen = screen;
        }
		
		public string UrlPathSegment { get; } = "$safeitemname$";

        public IScreen HostScreen { get; }

        public ViewModelActivator Activator { get; } = new ViewModelActivator();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
