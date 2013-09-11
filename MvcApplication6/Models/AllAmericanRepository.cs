using System.Collections.Generic;
using System.Linq;

namespace MvcApplication6.Models
{
    public class AllAmericanRepository
    {

        #region Player List

        private static List<Player> _Players = new List<Player>()
        {
            new Player("W. T. (Mother) Dunn (1906)"),
            new Player("Bob Higgins (1915, 1919)"),
            new Player("Percy W. (Red) Griffiths (1920)"),
            new Player("Charley Way (1920)"),
            new Player("Glenn Killinger (1921)"),
            new Player("Harry (Light Horse) Wilson (1923)"),
            new Player("Joe Bedenk (1923)"),
            new Player("Leon Gajecki (1940)"),
            new Player("Steve Suhey (1947)"),
            new Player("Sam Tamburo (1948)"),
            new Player("Sam Valentine (1956)"),
            new Player("Richie Lucas (1959)"),
            new Player("Bob Mitinger (1961)"),
            new Player("Dave Robinson (1962)"),
            new Player("Roger Kochman (1962)"),
            new Player("Glenn Ressler (1964)"),
            new Player("Ted Kwalick (1967, 1968)"),
            new Player("Dennis Onkotz (1968, 1969)"),
            new Player("Mike Reid (1969)"),
            new Player("Charlie Pittman (1969)"),
            new Player("Neal Smith (1969)"),
            new Player("Jack Ham (1970)"),
            new Player("Dave Joyner (1971)"),
            new Player("Lydell Mitchell (1971)"),
            new Player("Charlie Zapiec (1971)"),
            new Player("Bruce Bannon (1972)"),
            new Player("John Hufnagel (1972)"),
            new Player("John Skorupan (1972)"),
            new Player("John Cappelletti (1973)"),
            new Player("Randy Crowder (1973)"),
            new Player("Ed O’Neil (1973)"),
            new Player("John Nessel (1974)"),
            new Player("Mike Hartenstine (1974)"),
            new Player("Chris Bahr (1975)"),
            new Player("Greg Buttle (1975)"),
            new Player("Tom Rafferty (1975)"),
            new Player("Kurt Allerman (1976)"),
            new Player("Keith Dorney (1977, 1978)"),
            new Player("Randy Sidler (1977)"),
            new Player("Matt Bahr (1978)"),
            new Player("Bruce Clark (1978, 1979)"),
            new Player("Chuck Fusina (1978)"),
            new Player("Pete Harris (1978)"),
            new Player("Matt Millen (1978)"),
            new Player("Bill Dugan (1980)"),
            new Player("Sean Farrell (1980, 1981)"),
            new Player("Curt Warner (1981, 1982)"),
            new Player("Walker Lee Ashley (1982)"),
            new Player("Kenny Jackson (1982, 1983)"),
            new Player("Mark Robinson (1982)"),
            new Player("Michael Zordich (1985)"),
            new Player("Shane Conlan (1985, 1986)"),
            new Player("Chris Conlin (1986)"),
            new Player("D. J. Dozier (1986)"),
            new Player("Tim Johnson (1986)"),
            new Player("Steve Wisniewski (1987, 1988)"),
            new Player("Andre Collins (1989)"),
            new Player("Blair Thomas (1989)"),
            new Player("Darren Perry (1991)"),
            new Player("O. J. McDuffie (1992)"),
            new Player("Lou Benfatti (1993)"),
            new Player("Kyle Brady (1994)"),
            new Player("Ki-Jana Carter (1994)"),
            new Player("Kerry Collins (1994)"),
            new Player("Bobby Engram (1994)"),
            new Player("Jeff Hartings (1994, 1995)"),
            new Player("Kim Herring (1996)"),
            new Player("Curtis Enis (1997)"),
            new Player("LaVar Arrington (1998, 1999)"),
            new Player("Courtney Brown (1999)"),
            new Player("Brandon Short (1999)"),
            new Player("Michael Haynes (2002)"),
            new Player("Larry Johnson (2002)"),
            new Player("Jimmy Kennedy (2002)"),
            new Player("Tamba Hali (2005)"),
            new Player("Paul Posluszny (2005, 2006)"),
            new Player("Alan Zemaitis (2005)"),
            new Player("Dan Connor (2006, 2007)"),
            new Player("Sean Lee (2007)"),
            new Player("A. Q. Shipley (2008)"),
            new Player("Aaron Maybin (2008)"),
            new Player("Jared Odrick (2009)"),
            new Player("Stefen Wisniewski (2010)"),
            new Player("Devon Still (2011)"),
            new Player("Michael Mauti (2012)")
        };

        #endregion

        public IQueryable<Player> GetPlayers()
        {
            return _Players.AsQueryable();
        }

        public void AddPlayer(Player newPlayer)
        {
            _Players.Add(newPlayer);
        }

    }

}