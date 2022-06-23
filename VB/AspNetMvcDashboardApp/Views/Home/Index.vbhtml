<script src="~/Scripts/WidgetsCustomization.js"></script>
@Html.DevExpress().Dashboard(
Sub(settings)
    settings.Name = "Dashboard"
    settings.ControllerName = "DefaultDashboard"
    settings.Width = Unit.Percentage(100)
    settings.Height = Unit.Percentage(100)
    settings.WorkingMode = DevExpress.DashboardWeb.WorkingMode.Viewer
    settings.ClientSideEvents.BeforeRender = "onBeforeRender"
End Sub).GetHtml()
