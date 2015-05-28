/*
 * FileName: Pawn.cs
 * Author: Bill Golembieski
 * Initial Implementation: 05/27/2015
 */

using System;

namespace Chess.Domain
{
    public class Pawn
    {
        private ChessBoard _chessBoard;
        private int _xCoordinate;
        private int _yCoordinate;
        private PieceColor _pieceColor;
        
        public ChessBoard ChessBoard
        {
            get { return _chessBoard; }
            set { _chessBoard = value; }
        }

        public int XCoordinate
        {
            get { return _xCoordinate; }
            set { _xCoordinate = value; }
        }
        
        public int YCoordinate
        {
            get { return _yCoordinate; }
            set { _yCoordinate = value; }
        }

        public PieceColor PieceColor
        {
            get { return _pieceColor; }
            private set { _pieceColor = value; }
        }

        public Pawn(PieceColor pieceColor)
        {
            _pieceColor = pieceColor;
        }


        public void Move(MovementType movementType, int newX, int newY)
        {
            // Precondition: A move type, newX and newY values are taken as input.
            // PostCondition: If a valid move is made, the pawn will move to that location, otherwise
            // nothing will happen.

            // Library Facilities used: System (if Capture is implemented)

            // Black Pawn Movement
            if (PieceColor == PieceColor.Black)
            {
                if (movementType == MovementType.Move)
                {
                    if (YCoordinate - newY == 1)
                    {
                        if (XCoordinate - newX == 0)
                        {
                            YCoordinate = newY;
                        }
                    }
                }
                /*
                // Black Non-Tested Capture Movement. 
                // Assuming Pawn.Move() is not called to capture outside of Chessboard Bounds.
                else if (movementType == MovementType.Capture)
                {
                    if ((YCoordinate - newY) == 1)
                    {
                        if (Math.Abs(XCoordinate - newX) == 1)
                        {
                            XCoordinate = newX;
                            YCoordinate = newY;
                        }
                        // else { TryAgain("Error Code: 110 X move capture Error"); }
                    }
                    // else { TryAgain("Error Code: 111 Y move capture Error"); }
                }
                */
            }
            // White Pawn Movement
            else if(PieceColor == PieceColor.White)
            {
                if (movementType == MovementType.Move)
                {
                    if (newY - YCoordinate == 1)
                    {
                        if (XCoordinate - newX == 0)
                        {
                            YCoordinate = newY;
                        }
                    }
                }
                /*
                // White Non-Tested Capture Movement. 
                // Assuming Pawn.Move() is not called to capture outside of Chessboard Bounds.
                else if (movementType == MovementType.Capture)
                {
                    if ((newY - YCoordinate) == 1)
                    {
                        if (Math.Abs(XCoordinate - newX) == 1)
                        {
                            XCoordinate = newX;
                            YCoordinate = newY;
                        }
                        // else { TryAgain("Error Code: 110 X move capture Error"); }
                    }
                    // else { TryAgain("Error Code: 111 Y move capture Error"); }
                }
                 */
            }
            // else { TryAgain("Error Code: 120 Piece Color undefined"); }
         }

        public override string ToString()
        {
            return CurrentPositionAsString();
        }

        protected string CurrentPositionAsString()
        {
            return string.Format("Current X: {1}{0}Current Y: {2}{0}Piece Color: {3}", Environment.NewLine, XCoordinate, YCoordinate, PieceColor);
        }

    }
}
