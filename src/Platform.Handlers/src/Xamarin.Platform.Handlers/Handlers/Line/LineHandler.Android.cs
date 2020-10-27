﻿namespace Xamarin.Platform.Handlers
{
	public partial class LineHandler : AbstractViewHandler<ILine, NativeLine>
	{
		protected override NativeLine CreateNativeView() => new NativeLine(Context);
	}
}
