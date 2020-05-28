using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp
{
	class Program
	{

		//the field of play
		static char[,] playField =
		{
			{'1', '2', '3' },
			{'4', '5', '6' },
			{'7', '8', '9' }
		};

		static char[,] playFieldInitial =
		{
			{'1', '2', '3' },
			{'4', '5', '6' },
			{'7', '8', '9' }
		};

		static int turns = 0;

		static void Main( string[] args )
		{
			int player = 2; //PLayer 1 starts
			int input = 0;
			bool validInput = true;


			do
			{
				if ( player == 2 )
				{
					player = 1;
					EnterXorO( 'O', input );
				}
				else if ( player == 1 )
				{
					player = 2;
					EnterXorO( 'X', input );
				}

				SetField();
				#region
				//Check Winning condition
				char[] playerChars = { 'X', 'O' };

				foreach ( char playerChar in playerChars )
				{
					if ( ( ( playField[ 0, 0 ] == playerChar ) && ( playField[ 0, 1 ] == playerChar ) && ( playField[ 0, 2 ] == playerChar ) )
						|| ( ( playField[ 1, 0 ] == playerChar ) && ( playField[ 1, 1 ] == playerChar ) && ( playField[ 1, 2 ] == playerChar ) )
						|| ( ( playField[ 2, 0 ] == playerChar ) && ( playField[ 2, 1 ] == playerChar ) && ( playField[ 2, 2 ] == playerChar ) )
						|| ( ( playField[ 0, 0 ] == playerChar ) && ( playField[ 1, 0 ] == playerChar ) && ( playField[ 2, 0 ] == playerChar ) )
						|| ( ( playField[ 0, 1 ] == playerChar ) && ( playField[ 1, 1 ] == playerChar ) && ( playField[ 2, 1 ] == playerChar ) )
						|| ( ( playField[ 0, 2 ] == playerChar ) && ( playField[ 2, 1 ] == playerChar ) && ( playField[ 2, 2 ] == playerChar ) )
						|| ( ( playField[ 0, 0 ] == playerChar ) && ( playField[ 1, 1 ] == playerChar ) && ( playField[ 2, 2 ] == playerChar ) )
						|| ( ( playField[ 0, 2 ] == playerChar ) && ( playField[ 1, 1 ] == playerChar ) && ( playField[ 2, 0 ] == playerChar ) )
						)
					{
						if ( playerChar == 'X' )
						{
							Console.WriteLine( "\n Player 2 has won!" );
						}
						if ( playerChar == 'O' )
						{
							Console.WriteLine( "\n Player 1 has won!" );
						}

						Console.WriteLine( "Press any key to reset the game." );
						Console.ReadKey();
						ResetField();
						break;
					}
					else if ( turns == 10 )
					{
						Console.WriteLine( "\n Game has ended in a DRAW." );
						Console.WriteLine( "Press any key to reset the game." );
						Console.ReadKey();
						ResetField();
						break;
					}
				}
				#endregion

				#region
				//Tests if field has been taken or not.
				do
				{
					Console.Write( "\nPlayer {0}: Choose your field! ", player );
					try
					{
						input = Convert.ToInt32( Console.ReadLine() );
					}
					catch
					{

						Console.WriteLine( "Please enter a number" );
					}

					if ( ( input == 1 ) && ( playField[ 0, 0 ] == '1' ) )
						validInput = true;
					else if ( ( input == 2 ) && ( playField[ 0, 1 ] == '2' ) )
						validInput = true;
					else if ( ( input == 3 ) && ( playField[ 0, 2 ] == '3' ) )
						validInput = true;
					else if ( ( input == 4 ) && ( playField[ 1, 0 ] == '4' ) )
						validInput = true;
					else if ( ( input == 5 ) && ( playField[ 1, 1 ] == '5' ) )
						validInput = true;
					else if ( ( input == 6 ) && ( playField[ 1, 2 ] == '6' ) )
						validInput = true;
					else if ( ( input == 7 ) && ( playField[ 2, 0 ] == '7' ) )
						validInput = true;
					else if ( ( input == 8 ) && ( playField[ 2, 1 ] == '8' ) )
						validInput = true;
					else if ( ( input == 9 ) && ( playField[ 2, 2 ] == '9' ) )
						validInput = true;
					else
					{
						Console.WriteLine( "\nField has already been selected. Please select another field." );
						validInput = false;
					}

				} while ( !validInput );

				#endregion
			}
			while ( true );
		}

		public static void ResetField()
		{
			char[,] playFieldInitial =
			{
				{'1', '2', '3' },
				{'4', '5', '6' },
				{'7', '8', '9' }
			};

			playField = playFieldInitial;
			SetField();
			turns = 1;
		}

		public static void SetField()
		{
			Console.Clear();
			Console.WriteLine( "     |     |     " );
			Console.WriteLine( "  {0}  |  {1}  |  {2}", playField[ 0, 0 ], playField[ 0, 1 ], playField[ 0, 2 ] );
			Console.WriteLine( "_____|_____|_____" );
			Console.WriteLine( "     |     |     " );
			Console.WriteLine( "  {0}  |  {1}  |  {2}", playField[ 1, 0 ], playField[ 1, 1 ], playField[ 1, 2 ] );
			Console.WriteLine( "_____|_____|_____" );
			Console.WriteLine( "     |     |     " );
			Console.WriteLine( "  {0}  |  {1}  |  {2}", playField[ 2, 0 ], playField[ 2, 1 ], playField[ 2, 2 ] );
			Console.WriteLine( "     |     |     " );
			turns++;
		}

		public static void EnterXorO( char playerSign, int input )
		{

			switch ( input )
			{
				case 1: playField[ 0, 0 ] = playerSign; break;
				case 2: playField[ 0, 1 ] = playerSign; break;
				case 3: playField[ 0, 2 ] = playerSign; break;
				case 4: playField[ 1, 0 ] = playerSign; break;
				case 5: playField[ 1, 1 ] = playerSign; break;
				case 6: playField[ 1, 2 ] = playerSign; break;
				case 7: playField[ 2, 0 ] = playerSign; break;
				case 8: playField[ 2, 1 ] = playerSign; break;
				case 9: playField[ 2, 2 ] = playerSign; break;
			}
		}
	}
}
