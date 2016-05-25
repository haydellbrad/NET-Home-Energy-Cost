Public Class Brad_Haydell_P3
    Dim pricePerDayValue As Double
    Dim costpkwh As Double
    Dim appliancekwh As Double
    Dim hourspd As Double
    Dim selection As String
    Dim waterCost As Double
    Dim wph As Double
    Dim cpg As Double

    'When user selects appliance, all controls are reset to default numbers as if it were a new form load
    'If user choose either Clothes Washer or Dishwasher, then the user will be able to enter both the 
    'number of gallons of water used by the appliance per hour and the cost per gallon. If the user then
    'chooses an appliance that does not use water, the that GroupBox will be hidden again.


    Private Sub SelectAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectAppliance.SelectedIndexChanged
        Try
            resetNumbers()
            checkNumbers()
            selection = SelectAppliance.Text.ToString
            SelectedApp.Text = selection

            If IsNumeric(TBCost.Text) And IsNumeric(TBAppliance.Text) And IsNumeric(TBHours.Text) Then
                checkHours()
            End If

            If SelectedApp.Text = "Clothes Washer" Or SelectedApp.Text = "Dishwasher" Then
                WaterFieldBox.Show()

            Else
                WaterFieldBox.Hide()
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Procedure for resetting the user data entry points everytime a user chooses a different
    'appliance.

    Private Sub resetNumbers()
        Try
            DisplayMessage.Text = " "
            TBCost.Text = FormatCurrency("0")
            TBAppliance.Text = "0"
            TBHours.Text = "0"
            DailyCost.Text = FormatCurrency("0")
            If SelectedApp.Text = "Clothes Washer" Or SelectedApp.Text = "Dishwasher" Then
                WaterPerHour.Text = "0"
                costPerGal.Text = FormatCurrency("0")
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Checks to see if there is a numeric value in each of the textboxes.

    Private Sub checkNumbers()
        Try
            If Not IsNumeric(TBCost.Text) Then
                DisplayMessage.Text = "Please enter a numeric value for Cost per kWh"
            End If

            If Not IsNumeric(TBAppliance.Text) Then
                DisplayMessage.Text = "Please enter a numeric value for Appliance kWh"
            End If

            If Not IsNumeric(TBHours.Text) Then
                DisplayMessage.Text = "Please enter a numeric value for Hours per Day"
            End If

            If Not IsNumeric(WaterPerHour.Text) Then
                DisplayMessage.Text = "Please enter a numeric value for Water per Hour"
            End If

            If Not IsNumeric(costPerGal.Text) Then
                DisplayMessage.Text = "Please enter a numeric value for Cost per Gallon"
            End If

        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Checks to see if a negative number is entered for Cost per kWh. IF Cost per kWh is greater than a reasonable range for the particular appliance,
    'displays message to enter a lower value.

    Private Sub checkCost()
        Try
            If costpkwh < 0 Then
                DisplayMessage.Text = "Please enter a positive number for Cost Per kWh."
            ElseIf costpkwh > 0.41 Then
                DisplayMessage.Text = "The highest cost per kWh in the world is $0.41. Enter a lower Cost Per kWh."
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Checks to see if a negative number is entered for Water per Hour. IF Water per Hour is greater than a reasonable range for the particular appliance,
    'displays message to enter a lower value.

    Private Sub checkWater()
        Try
            Select Case (selection)
                Case "Clothes Washer"
                    If wph < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Water per Hour for Clothes Washer"
                    ElseIf wph > 40 Then
                        DisplayMessage.Text = "The highest Gallons per Hour for a Clothes Washer is 40 gallons. Enter a lower Water per Hour."
                    End If
                Case "Dishwasher"
                    If wph < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Water per Hour for Dishwasher."
                    ElseIf wph > 15 Then
                        DisplayMessage.Text = "The highest Gallons per Hour for a Dishwasher is 15 gallons per load. Enter a lower Water per Hour."
                    End If
            End Select

        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Checks to see if a negative number is entered for Cost per Gallons. IF Cost per Gallon is greater than a reasonable range for the particular appliance,
    'displays message to enter a lower value.

    Private Sub checkGalCost()
        Try
            If cpg < 0 Then
                DisplayMessage.Text = "Please enter a positive number for Cost per Gallon."
            ElseIf cpg > 0.02 Then
                DisplayMessage.Text = "The highest Cost per Gallon of water in the world is 1.28 cents. Enter a lower Cost per Gallon."
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Checks to see if a negative number is entered for Appliance kWh. IF kWh is greater than a reasonable range for the particular appliance,
    'displays message to enter a lower value.

    Private Sub checkAppliance()
        appliancekwh = TBAppliance.Text
        Try
            Select Case (selection)
                Case "Air Conditioner"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for an Air Conditioner."
                    ElseIf appliancekwh > 5.0 Then
                        DisplayMessage.Text = "The highest kWh for a typical Central Air Conditioner is around 5.0 kWh. Enter lower Appliance kWh."
                    End If
                Case "Clothes Washer"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for a Clothes Washer."
                    ElseIf appliancekwh > 1.3 Then
                        DisplayMessage.Text = "The highest kWh for a Clothes Washer is around 1.3 kWh. Enter lower Appliance kWh."
                    End If
                Case "Dishwasher"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for a Dishwasher."
                    ElseIf appliancekwh > 2.4 Then
                        DisplayMessage.Text = "The highest kWh for a Dishwasher is around 2.4 kWh. Enter lower Appliance kWh."
                    End If
                Case "Refrigerator"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for a Refrigerator."
                    ElseIf appliancekwh > 0.4 Then
                        DisplayMessage.Text = "The highest kWh for a Refrigerator is around .4 kWh. Enter lower Appliance kWh."
                    End If
                Case "TV"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for a TV."
                    ElseIf appliancekwh > 0.3 Then
                        DisplayMessage.Text = "The highest kWh for a 50 inch Plasma TV is around .3 kWh. Enter lower Appliance kWh."
                    End If
                Case "Space Heater"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for a Space Heater."
                    ElseIf appliancekwh > 1.5 Then
                        DisplayMessage.Text = "The highest kWh for a portable Space Heater is around 1.5 kWh. Enter lower Appliance kWh."
                    End If
                Case "Fan"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for a Fan."
                    ElseIf appliancekwh > 0.1 Then
                        DisplayMessage.Text = "The highest kWh for a Fan is around .1 kWh. Enter lower Appliance kWh."
                    End If
                Case "Dryer"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for a Clothes Dryer."
                    ElseIf appliancekwh > 5.0 Then
                        DisplayMessage.Text = "The highest kWh for a Clothes Dryer is around 5 kWh. Enter lower Appliance kWh."
                    End If
                Case "Oven"
                    If appliancekwh < 0 Then
                        DisplayMessage.Text = "Please enter a positive number for Appliance kWh for an Oven."
                    ElseIf appliancekwh > 5.0 Then
                        DisplayMessage.Text = "The highest kWh for an Oven is around 5.0 kWh. Enter lower Appliance kWh."
                    End If
            End Select
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Checks to see if a hours entered are not about 24 hours or below 0 hours.

    Private Sub checkHours()
        Try
            If hourspd >= 0 And hourspd <= 24 Then
                DisplayMessage.Text = " "
                Select Case (selection)
                    Case "Air Conditioner"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 5.0 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "Clothes Washer"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 1.3 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "Dishwasher"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 2.4 And waterCost >= 0 And wph >= 0 And wph <= 15 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "Refrigerator"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 0.4 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "TV"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 0.3 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "Space Heater"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 1.5 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "Fan"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 0.1 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "Dryer"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 5.0 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                    Case "Oven"
                        If costpkwh >= 0 And costpkwh <= 0.41 And appliancekwh >= 0 And appliancekwh <= 5.0 And waterCost >= 0 And wph >= 0 And wph <= 40 And cpg >= 0 And cpg < 0.02 Then
                            calculateDailykWh()
                        Else
                            checkCost()
                            checkWater()
                            checkGalCost()
                            checkAppliance()
                        End If
                End Select
            Else
                DisplayMessage.Text = "Hours per day needs to be from 0 to 24."
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Procedure to perform the calculations for the daily cost of the appliances

    Private Sub calculateDailykWh()
        costpkwh = TBCost.Text
        appliancekwh = TBAppliance.Text
        hourspd = TBHours.Text
        wph = WaterPerHour.Text
        cpg = costPerGal.Text
        waterCost = wph * cpg

        If SelectedApp.Text = "Clothes Washer" Or SelectedApp.Text = "Dishwasher" Then
            pricePerDayValue = ((appliancekwh * hourspd) * costpkwh) + (waterCost)
        Else
            pricePerDayValue = (appliancekwh * hourspd) * costpkwh
        End If
        DailyCost.Text = FormatCurrency(pricePerDayValue, TriState.True, TriState.True)
    End Sub

    'Appliance needs to be chosen and all inputs are numeric for calculation to happen.

    Private Sub TBCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBCost.TextChanged
        Try
            If SelectAppliance.Text = "Air Conditioner" Or SelectedApp.Text = "Clothes Washer" Or SelectedApp.Text = "Dishwasher" Or SelectAppliance.Text = "Refrigerator" Or SelectAppliance.Text = "TV" Or
                    SelectAppliance.Text = "Space Heater" Or SelectAppliance.Text = "Fan" Or SelectAppliance.Text = "Dryer" Or
                    SelectAppliance.Text = "Oven" Then
                If IsNumeric(TBCost.Text) And IsNumeric(TBAppliance.Text) And IsNumeric(TBHours.Text) Then
                    costpkwh = Double.Parse(TBCost.Text)
                    checkHours()
                Else
                    checkNumbers()
                End If
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Appliance needs to be chosen and all inputs are numeric for calculation to happen.

    Private Sub TBAppliance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBAppliance.TextChanged
        Try
            If SelectAppliance.Text = "Air Conditioner" Or SelectedApp.Text = "Clothes Washer" Or SelectedApp.Text = "Dishwasher" Or SelectAppliance.Text = "Refrigerator" Or SelectAppliance.Text = "TV" Or
                    SelectAppliance.Text = "Space Heater" Or SelectAppliance.Text = "Fan" Or SelectAppliance.Text = "Dryer" Or
                    SelectAppliance.Text = "Oven" Then
                If IsNumeric(TBCost.Text) And IsNumeric(TBAppliance.Text) And IsNumeric(TBHours.Text) Then
                    appliancekwh = Double.Parse(TBAppliance.Text)
                    checkHours()
                Else
                    checkNumbers()
                End If
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Appliance needs to be chosen and all inputs are numeric for calculation to happen.

    Private Sub TBHours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBHours.TextChanged
        Try
            If SelectAppliance.Text = "Air Conditioner" Or SelectedApp.Text = "Clothes Washer" Or SelectedApp.Text = "Dishwasher" Or SelectAppliance.Text = "Refrigerator" Or SelectAppliance.Text = "TV" Or
                    SelectAppliance.Text = "Space Heater" Or SelectAppliance.Text = "Fan" Or SelectAppliance.Text = "Dryer" Or
                    SelectAppliance.Text = "Oven" Then
                If IsNumeric(TBCost.Text) And IsNumeric(TBAppliance.Text) And IsNumeric(TBHours.Text) Then
                    hourspd = Double.Parse(TBHours.Text)
                    checkHours()
                Else
                    checkNumbers()
                End If
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Appliance needs to be chosen and all inputs are numeric for calculation to happen.

    Private Sub WaterPerHour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaterPerHour.TextChanged
        Try
            If SelectAppliance.Text = "Clothes Washer" Or SelectAppliance.Text = "Dishwasher" Then
                If IsNumeric(TBCost.Text) And IsNumeric(TBAppliance.Text) And IsNumeric(TBHours.Text) And IsNumeric(WaterPerHour.Text) And IsNumeric(costPerGal.Text) Then
                    wph = Double.Parse(WaterPerHour.Text)
                    checkHours()
                Else
                    checkNumbers()
                End If
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Appliance needs to be chosen and all inputs are numeric for calculation to happen.

    Private Sub costPerGal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles costPerGal.TextChanged
        Try
            If SelectAppliance.Text = "Clothes Washer" Or SelectAppliance.Text = "Dishwasher" Then
                If IsNumeric(TBCost.Text) And IsNumeric(TBAppliance.Text) And IsNumeric(TBHours.Text) _
                    And IsNumeric(WaterPerHour.Text) And IsNumeric(costPerGal.Text) Then
                    cpg = Double.Parse(costPerGal.Text)
                    checkHours()
                Else
                    checkNumbers()
                End If
            End If
        Catch ex As Exception
            DisplayMessage.Text = ex.Message
        End Try
    End Sub

    'Reset everything back to default values

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        TBCost.Text = FormatCurrency("0")
        TBAppliance.Text = "0"
        TBHours.Text = "0"
        SelectAppliance.Text = "None"
        DailyCost.Text = FormatCurrency("0")
        DataEntryList.Clear()
        DisplayMessage.Text = " "
    End Sub

    'When form loads, sets default values

    Private Sub Brad_Haydell_P3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBCost.Text = FormatCurrency("0")
        TBAppliance.Text = "0"
        TBHours.Text = "0"
        SelectAppliance.Text = "None"
        DailyCost.Text = FormatCurrency("0")
        WaterPerHour.Text = "0"
        costPerGal.Text = FormatCurrency("0")
        WaterFieldBox.Hide()
    End Sub

    'When the Add to List button is clicked, Text will be appended to the Rich text box.

    Private Sub AddToList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddToList.Click
        calculateDailykWh()
        If selection.Length >= 5 Then
            DataEntryList.AppendText(Space(6) & selection & vbTab & Space(6) & "|" & vbTab & vbTab &
                                     hourspd & vbTab & Space(7) & "|" & vbTab & Space(8) &
                                     FormatCurrency(pricePerDayValue, TriState.True, TriState.True) &
                                     Environment.NewLine)
        ElseIf selection.Length < 5 Then
            DataEntryList.AppendText(Space(6) & selection & vbTab & vbTab & Space(6) & "|" & vbTab &
                                     vbTab & hourspd & vbTab & Space(7) & "|" & vbTab & Space(8) &
                                     FormatCurrency(pricePerDayValue, TriState.True, TriState.True) &
                                     Environment.NewLine)
        End If

    End Sub


End Class
