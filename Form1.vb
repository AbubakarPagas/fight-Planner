Public Class frmFlight
    Private Sub Form_load()
        lstCities.Items("San Diego")


    End Sub
    Private Sub cboSeat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeat.SelectedIndexChanged


    End Sub

    Private Sub lstCities_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCities.SelectedIndexChanged
        lstCities.ClearSelected()
        lstCities.Text = "los Angeles"






    End Sub

    Private Sub frmFlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
