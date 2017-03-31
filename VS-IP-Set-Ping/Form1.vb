Imports System.Management
Public Class Form1
    'get list of adapters to set
    'populate a dropdown list

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLog.Text = ""
    End Sub

    Private Sub btnSetIP_Click(sender As Object, e As EventArgs) Handles btnSetIP.Click
        Dim IPAddress As String = txtIP.Text
        Dim SubnetMask As String = txtSM.Text
        Dim Gateway As String = txtGW.Text
        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        For Each objMO As ManagementObject In objMOC
            If (Not CBool(objMO("IPEnabled"))) Then
                Continue For
            End If

            Try
                Dim objNewIP As ManagementBaseObject = Nothing
                Dim objSetIP As ManagementBaseObject = Nothing
                Dim objNewGate As ManagementBaseObject = Nothing
                txtLog.Text = txtLog.Text + vbCrLf + objMO("Description")
                objNewIP = objMO.GetMethodParameters("EnableStatic")
                objNewGate = objMO.GetMethodParameters("SetGateways")

                'Set DefaultGateway
                objNewGate("DefaultIPGateway") = New String() {Gateway}
                objNewGate("GatewayCostMetric") = New Integer() {1}

                'Set IPAddress and Subnet Mask
                objNewIP("IPAddress") = New String() {IPAddress}
                objNewIP("SubnetMask") = New String() {SubnetMask}

                objSetIP = objMO.InvokeMethod("EnableStatic", objNewIP, Nothing)
                objSetIP = objMO.InvokeMethod("SetGateways", objNewGate, Nothing)

                Console.WriteLine("Updated IPAddress, SubnetMask and Default Gateway!")
                txtLog.Text = txtLog.Text + vbCrLf + "Updated settings. "
            Catch ex As Exception
                MessageBox.Show("Unable to Set IP : " & ex.Message)
                txtLog.Text = txtLog.Text + vbCrLf + "Unable to Set IP : " & ex.Message
            End Try
        Next objMO
    End Sub

    Private Sub btnAdaptRef_Click(sender As Object, e As EventArgs) Handles btnAdaptRef.Click
        cmbAdapters.Items.Clear()
        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        For Each objMO As ManagementObject In objMOC
            If (Not CBool(objMO("IPEnabled"))) Then
                Continue For
            End If
            cmbAdapters.Items.Add(objMO("Index") & "-" & objMO("Description"))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAdaptRef_Click(sender, e)

    End Sub

    Private Sub cmbAdapters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAdapters.SelectedIndexChanged

    End Sub
End Class
