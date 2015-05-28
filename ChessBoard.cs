/*
 * FileName: ChessBoard.cs
 * Author: Bill Golembieski
 * Initial Implementation: 05/27/2015
 */

using System;

namespace Chess.Domain
{
    public class ChessBoard
    {
        public static readonly int MaxBoardWidth = 7;
        public static readonly int MaxBoardHeight = 7;
        private Pawn[,] pieces;

        public ChessBoard ()
        {
            pieces = new Pawn[MaxBoardWidth, MaxBoardHeight];
        }

        public void Add(Pawn pawn, int xCoordinate, int yCoordinate, PieceColor pieceColor)
        {
            /* Pre-Condition: Intake of Pawn Object, 2 integers (x,y coordinates) and Enum Piececolor (black or white).
             * Post-Condition:  Pawn Object with input generated (x,y) coordinates and color. */
            pawn.XCoordinate = xCoordinate;
            pawn.YCoordinate = yCoordinate;

            // Set private _pieceColor using mutator Pawn() in Pawn.
            pawn = new Pawn(pieceColor);
        }

        public bool IsLegalBoardPosition(int xCoordinate, int yCoordinate)
        {        
        /* Pre-Condition: Intake of 2 integers (x,y) coordinates.
         * Post-Condition: Returns true or false based max values of width and height.*/

            if(xCoordinate >= 0 && yCoordinate >= 0)
            {       
                if ((MaxBoardHeight >= yCoordinate))
                {
                    if ((MaxBoardWidth >= xCoordinate))
                    {
                        return true;
                    }
                    else { return false; }                       
                }
                else { return false; }                        
            }
            else { return false; }                            
        }
    }
}
