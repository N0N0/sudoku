using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form{

        private IntTextBox[,] feld = new IntTextBox[9, 9];

        /// <summary>
        /// verhindert das überprüfen von feldwerten (beschleunigt das Laden von spielen)
        /// </summary>
        private Boolean isLoading = false;


        public Form1(){
            InitializeComponent();

            // Das Array aus IntegerFeldern erzeugen und an die Form hängen
            for (int zeile = 0; zeile < 9; zeile++){

                for (int spalte = 0; spalte < 9; spalte++){
                    feld[zeile, spalte] = new IntTextBox();
                    this.feld[zeile, spalte].Location = new System.Drawing.Point(spalte * 40, zeile * 40);
                    this.feld[zeile, spalte].Font = Constants.GAME_DEFAULT_FONT;
                    this.feld[zeile, spalte].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    this.feld[zeile, spalte].Name = "feld" + zeile + spalte;
                    this.feld[zeile, spalte].Size = new System.Drawing.Size(32, 30);
                    this.feld[zeile, spalte].TabIndex = 0;
                    this.feld[zeile, spalte].TextChanged += new System.EventHandler(this.feld_TextChanged);
                    this.Controls.Add(feld[zeile, spalte]);
                }

            }
            loadRandomGame();
        }
        
        
		/// <summary>
		/// Führt für jedes Feld des Spielrasters die Reset Methode aus.
		/// </summary>
		/// <param name="fullReset">Sollen auch der Inhalt und der Status "Checked" resetted werden?</param>
        private void felderResetten(Boolean fullReset){
            for (int zeile = 0; zeile < 9; zeile++){
                for (int spalte = 0; spalte < 9; spalte++){
					feld[zeile,spalte].reset(fullReset);
                }
            }
        }
		

        /// <summary>
        /// Ruft für jedes Feld, dessen Farbsetzungsmethode auf.
        /// </summary>
        private void felderEinfaerben(){
            for (int zeile = 0; zeile < 9; zeile++){
                for (int spalte = 0; spalte < 9; spalte++){
                    feld[zeile, spalte].setColor();
                }
            }
        }


        /// <summary>
        /// Wird ausgeführt sobald sich der Text eines Feldes ändert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void feld_TextChanged(object sender, EventArgs e) {

            if ( !isLoading ) { // wird nur ausgeführt wenn das Spielfeld bereits aufgebaut wurde
                IntTextBox werWars = (IntTextBox)sender;

                String feldName = werWars.Name;

                int xpos = Convert.ToInt16(feldName.Substring(feldName.Length - 2, 1));
                int ypos = Convert.ToInt16(feldName.Substring(feldName.Length - 1, 1));

                felderResetten(false);
               	checkAllFields();
                felderEinfaerben();
            }
        }
		
        
        private void checkAllFields(){
        	for (int i = 0; i < 9; i++){
        		for(int k = 0; k <9; k++){
        			    checkAllBlocks(i,k);
        		    	checkAllRows(i);
        		    	checkAllColumns(k);
        		    	checkAllBlocks(i,k);
        		    }
        	}
        }
        

        /// <summary>
        /// Führt nacheinander alle Checkmethoden aus.
        /// </summary>
        /// <param name="ypos"></param>
        private void checkAllRows(int ypos){

            for (int i = 0; i < 9; i++){
                for (int k = i+1; k < 9; k++){
	                if (feld[i, ypos].Text == feld[k, ypos].Text) {
	                    feld[i, ypos].doubleEntry = true;
	                    feld[k, ypos].doubleEntry = true;
	                    k++;
	                    break;
	                }
                }
            }

        }


        /// <summary>
        /// Prüft die Spalte der letzten Eingabe auf doppelte Einträge
        /// </summary>
        /// <param name="xpos"></param>
        private void checkAllColumns(int xpos) {

            for (int i = 0; i < 9; i++) {

                for (int k = i + 1; k < 9; k++) {
                    if (feld[xpos, i].Text == feld[xpos, k].Text) {
                        feld[xpos, i].doubleEntry = true;
                        feld[xpos, k].doubleEntry = true;
                        k++;
                        break;
                    }
                }

            }

        }

        
        // checks all blocks if they have double entries within
        private void checkAllBlocks(int xpos, int ypos){
        	
			// 1st identify whats the current block in the game grid1
			int blockStartCol = -1;
			int blockStartRow = -1;

			int dummy = xpos /2;			
			if(dummy  <=1)		{ blockStartCol = 0; }
			else if (dummy >=3)	{ blockStartCol = 6; }
			else				{ blockStartCol = 3; }
			
			dummy = ypos/2;
			if(dummy  <=1)		{ blockStartRow = 0; }
			else if (dummy >=3)	{ blockStartRow = 6; }
			else				{ blockStartRow = 3; }
			
			// now start comparing each field of the working block with each other
			for (int i=blockStartCol; i < (3 + blockStartCol); i++){
				for (int k=blockStartRow; k< (3 + blockStartRow); k++){
					checkWithinSpecificBlock(blockStartCol, blockStartRow, i, k);
				}
			}
        }

        // compares a given field with each other fields in the given block
        private void checkWithinSpecificBlock(int blockStartCol, int blockStartRow, int xpos, int ypos){
        	
        	for (int spalte = blockStartCol; spalte < (3+ blockStartCol); spalte++){
        		for (int zeile = blockStartRow; zeile< (3 + blockStartRow); zeile++){
        			if(spalte != xpos && zeile != ypos){
        				if(feld[spalte, zeile].Text == feld[xpos, ypos].Text){
        					feld[spalte, zeile].doubleEntry = true;
        					feld[xpos, ypos].doubleEntry = true;
        				}
        			}
        		}
        	}
        	
        }
        
        
        /// <summary>
        /// Läd ein zufällig gewähltes Spiel aus der Klasse Spiele.cs
        /// </summary>
        private void loadRandomGame(){

            this.isLoading = true;

            Spiele spiele = new Spiele();

            int[,] beispieldaten = spiele.getSudoku();
            // felder resetten
			felderResetten(true);
			
            // testdaten einspielen
            for (int zeile = 0; zeile < 9; zeile++){
                for (int spalte = 0; spalte < 9; spalte++){
                    if ( beispieldaten[zeile,spalte] != 0 ){
                        feld[zeile, spalte].Text = "" + beispieldaten[zeile, spalte];
                        feld[zeile, spalte].checkedEntry = true;
                    }
                }
            }
			
            // Farben setzen
            felderEinfaerben();

            this.isLoading = false;
        }


        /// <summary>
        /// Führt die Methode loadRandomGame aus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpielLaden_Click(object sender, EventArgs e){
            this.loadRandomGame();
        }


    }


}