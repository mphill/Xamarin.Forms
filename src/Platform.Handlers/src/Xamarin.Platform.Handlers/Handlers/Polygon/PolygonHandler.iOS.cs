﻿namespace Xamarin.Platform.Handlers
{
	public partial class PolygonHandler : AbstractViewHandler<IPolygon, NativePolygon>
	{
		protected override NativePolygon CreateNativeView() => new NativePolygon();
	}
}