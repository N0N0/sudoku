using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Sudoku{

    /// <summary>
    ///  Textfeld, dass nur eine(!) Zahl von 1-9 aufnehmen kann.
    ///  Bietet zusätzlich 3 boolsche Felder für das Sudoko-Spiel.
    /// </summary>
    public class IntTextBox : TextBox{

        public Boolean doubleEntry = false;
        public Boolean comment = false;
        public Boolean checkedEntry = false;


        protected override void OnKeyPress(KeyPressEventArgs e){

            base.OnKeyPress(e);

            int input = Convert.ToInt32(e.KeyChar);
            
            // Nur Zahlen verarbeiten wenn das Feld nicht checked ist, und dann nur Zahlwerte
            if ( !this.checkedEntry && ( (input >= 49 && input <= 57) || (input == 8)) ){
                this.Text = "";     // alten Text löschen, sorgt dafür, dass nur jeweils 1 zeichen verarbeitet wird
                return; // methode verlassen
            }

            e.Handled = true;   // eingabe als verarbeitet markieren ( entspricht ignorieren der Eingabe )

        }


        /// <summary>
        /// Setzt die Farbe des Feldes entsprechned seines Status (wrong, unchecked, checked)
        /// </summary>
        public void setColor(){
        	// checked entries will always be green
            if (this.checkedEntry){
                this.ForeColor = Constants.FIELD_COLOR_CHECKED;
            } else if (this.doubleEntry){
        		this.ForeColor = Constants.FIELD_COLOR_DOUBLE;
        	}
        	else {
                this.ForeColor =Constants.FIELD_COLOR_UNCHECKED;
            }
        }

        /// <summary>
        /// Löscht den Text und setzt alle drei Attribute zurück
        /// </summary>
        public void reset(Boolean fullReset){
            this.doubleEntry = false;
            if(fullReset){
        		this.Text = "";
            	this.checkedEntry = false;
	            this.comment = false;
            }
        }

    }

}
