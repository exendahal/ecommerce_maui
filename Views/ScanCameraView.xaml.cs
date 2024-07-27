namespace EcommerceMAUI.Views;

public partial class ScanCameraView : ContentPage
{
	public ScanCameraView()
	{
		InitializeComponent();
	}
    private void CameraViewCamerasLoaded(object sender, EventArgs e)
    {
        if (cameraView.Cameras.Count > 0)
        {
            cameraView.Camera = cameraView.Cameras.First();
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await cameraView.StopCameraAsync();
                await cameraView.StartCameraAsync();
            });
        }
    }

    private void CameraViewBarcodeDetected(object sender, Camera.MAUI.ZXingHelper.BarcodeEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await cameraView.StopCameraAsync();
            await Navigation.PopModalAsync();
        });
    }

    private async void CloseCamera(object sender, EventArgs e)
    {
        await cameraView.StopCameraAsync();
        Navigation.PopModalAsync();
    }
}