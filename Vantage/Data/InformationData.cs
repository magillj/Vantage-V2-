using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Vantage.Data
{
    public static class InformationData
    {
        public class Member
        {
            private string firstName;
            private string lastName;
            private string email;
            private string phoneNumber;
            private string initiation;

            public Member(string firstName, string lastName, string email, string phoneNumber, string initiation)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Email = email;
                this.PhoneNumber = phoneNumber;
                this.Initiation = initiation;
            }

            public string FirstName
            {
                get
                {
                    return firstName;
                }

                set
                {
                    firstName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }

                set
                {
                    lastName = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }

            public string PhoneNumber
            {
                get
                {
                    return phoneNumber;
                }

                set
                {
                    phoneNumber = value;
                }
            }

            public string Initiation
            {
                get
                {
                    return initiation;
                }

                set
                {
                    initiation = value;
                }
            }
        }

        public static List<Member> GetMembers()
        {
            List<List<string>> data = new List<List<string>>() {
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>(),
                new List<string>()
            };
            List<Member> result = new List<Member>();
            var count = 0;
            var reader = new StringReader(GetDummyDirectory());
            string line;
            /* Categories are seperated by blank line */
            while ((line = reader.ReadLine()).Length > 0)
            {
                count++;
            }
            reader = new StringReader(GetDummyDirectory());
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < count; j++)
                {
                    data[i].Add(reader.ReadLine());
                }
                /* Account for blank line seperator */
                reader.ReadLine();
            }
            for (var i = 0; i < count; i++)
            {
                result.Add(new Member(data[0][i], data[1][i],
                    data[2][i], data[4][i], data[3][i]));
            }
            return result;
        }

        public static List<Member> GetTestMembers()
        {
            return new List<Member>()
            {
                new Member("Derek", "Coley", "dmcoley@uw.edu",
                            "425-422-2063", "1782"),
                new Member("Jake", "Magill", "solidmagill@gmail.com",
                            "999-999-9999", "1763")
            };
        }

        private static string GetDummyDirectory()
        {
            return "Bryce\r\nErik\r\nTanner\r\nJohn\r\nJeffrey\r\nMichael\r\nNick\r\nKelsey\r\nMichael\r\nEvan\r\nMike\r\nDylan\r\nBrian\r\nKyle\r\nDavid\r\nRajan\r\nLucas\r\nChris\r\nBaxter\r\nRiley\r\nColin\r\nConnor\r\nNick\r\nGarrison\r\nJebraan\r\nAndy\r\nSaare\r\nDylan\r\nBrandon\r\nDaniel\r\nErik\r\nChristopher\r\nChris\r\nTrevor\r\nChristopher\r\nThomas\r\nDaniel\r\nEric\r\nStephen\r\nIsaac\r\nHunter\r\nBruce\r\nDylan\r\nTug\r\nAlex\r\nNate\r\nBrett\r\nErik\r\njared\r\nCameron\r\nRyan\r\nLane\r\nJacob\r\nAlex\r\nJohn\r\nChase\r\nTaylor\r\nChristian\r\nDwight\r\nShawn\r\nBryant\r\nScott\r\nBilly\r\nJorge\r\nRyan\r\nMarchael\r\ndavid\r\nBrandon\r\nAndrew\r\nJake\r\nJulian\r\nAlex\r\nMichael\r\nDominick\r\nHiro\r\nJonathan\r\nNicholas\r\nZach\r\nJacob\r\nElliot\r\nThomas\r\nsai\r\nMax\r\nTony\r\nSam\r\nZach\r\nZach\r\nRahul\r\nDerek\r\nJeremy\r\nJacob\r\nNicholas\r\nMac\r\nCasey\r\nAustin\r\nIan\r\nMatt\r\nAlec\r\nJuan\r\nTony\r\nTheodore\r\nMatt\r\nJoshua\r\nXavier\r\nWarren\r\nGarrett\r\nAlec\r\nMark\r\nOliver\r\nRobbie\r\nKenneth\r\nPavel\r\nChad\r\nCurt\r\nMaxime\r\nSean\r\nDane\r\nMichael\r\nSean\r\nBrandon\r\nErik\r\nDylan\r\nKevin\r\n\r\nHobbs\r\nLeutkehans\r\nFaubion\r\nIrwin\r\nHuschka\r\nAcode\r\nChambers\r\nLeek\r\nLauritzen\r\nHeitman\r\nJo\r\nTaylor\r\nLeer\r\nSant\r\nKuechle\r\nSelvan\r\nSmith\r\nAdan\r\nSmith\r\nZollars\r\nKirkmire\r\nColeman\r\nHenderson\r\nDePhillips\r\nGowani\r\nDessie\r\nTesfay\r\nJustus\r\nLangeland\r\nCol\u00F3n\r\nKivimaki\r\nCaluza\r\nKlaczynski\r\nKauf\r\nBrubaker\r\nFoster\r\nHsieh\r\nChin\r\nChung\r\nStockdale\r\nCowan\r\nAdsero\r\nRoss\r\nHarris\r\nPickett\r\nStockman\r\nBusch\r\nArntsen\r\nsmith\r\nMielke\r\nHale\r\nSchinnell\r\nWallace\r\nHuff\r\nBrendel\r\nKutsunai\r\nFaubion\r\nLarsen\r\nStoddard\r\nFranklin\r\nTaylor\r\nFeather\r\nStinson\r\nMaldonado\r\nPrescott\r\nAcode\r\ngarcia-palao agreda\r\nDonaldson\r\nBayles\r\nMagill\r\nDizon\r\nLin\r\nMuromoto\r\nCanady\r\nKusakabe\r\nMou\r\nArmitage\r\nDurham\r\nWessel\r\nVaughn\r\nMartinson\r\nruhlen\r\nLaRoche\r\nNipert\r\nPark\r\nHall\r\nZilke\r\nPerumal\r\nColey\r\nKnight\r\nKavanagh\r\nWeiss\r\nCook\r\nFranks\r\nMiller\r\nBrodie\r\nKelleher\r\nAzure\r\nZavaleta\r\nJo\r\nPappas\r\nWhitaker\r\nMielke\r\nGardner\r\nCho\r\nHutchison\r\nEge\r\nToda\r\nAlbee\r\nSchab\r\nGunning\r\nKazakov\r\nShapard\r\nHauser\r\nBlais\r\nUnderwood\r\nPollett\r\nFunk\r\nMcClanahan\r\nTerLouw\r\nEliason\r\nReynolds\r\nBrown\r\n\r\nbrycehobbs@gmail.com\r\neluetk@uw.edu\r\ntannman011@comcast.net\r\njirwin3@uw.edu\r\njeffhuschka@gmail.com\r\nmacode23@gmail.com\r\nnick811@comcast.net\r\nleek57@hotmail.com\r\nlauri12@uw.edu\r\nevanrheitman@gmail.com\r\nhmjo92@hotmail.com\r\nsurf.dmt@comcast.net\r\nbrianleer@live.com\r\nkylesant@msn.com\r\ndavid.kuechle@gmail.com\r\nrselvan@u.washington.edu\r\nsmithlucas23@yahoo.com\r\nchris_a_5@hotmail.com\r\nbaxtersmith91@hotmail.com\r\nrileypzollars@gmail.com\r\nkirkmirecp@gmail.com\r\nconnorco@uw.edu\r\nnbh3@uw.edu\r\ngtdephillips@yahoo.com\r\njebraan@live.com\r\nandargachew_dessie@hotmail.com\r\nSare425@yahoo.com\r\ndylanjustus1@gmail.com\r\nbrandonl090@yahoo.com\r\ndanielc7@uw.edu\r\njfkivimaki@gmail.com\r\ntopher88@uw.edu\r\ncklacy@uw.edu\r\ntrevorkauf@gmail.com\r\nbrubch91@uw.edu\r\nfostetho@uw.edu\r\ndanhsiehm@gmail.com\r\ne.sj.chin@gmail.com\r\nstevenc8@uw.edu\r\nisaacstockdale@rocketmail.com\r\ncowanhunter@gmail.com\r\nbruce.adsero@live.com\r\ndylanhross@gmail.com\r\ntugharris@gmail.com\r\najpickett1994@gmail.com\r\nnate.stockman54@gmail.com\r\nbkbusch32@hotmail.com\r\nerikonlummi@gmail.com\r\njared.smith27@hotmail.com\r\ncameron_j_mielke@hotmail.com\r\nralexhale@gmail.com\r\nschinnel@uw.edu\r\njacobwallace0330@gmail.com\r\nalexfhuff@comcast.net\r\njohn.brendel@comcast.net\r\nkutsunai11@gmail.com\r\nfaubit@uw.edu\r\nclarsen1@uw.edu\r\ndwightstoddard3@gmail.com\r\nshawnbfranklin@gmail.com\r\nbtaylor5@uw.edu\r\nsefeather@comcast.net\r\nbillstinson11@gmail.com\r\njorgem13180@gmail.com\r\nrmpcocoloco123@gmail.com\r\nmarchaelA_3232@hotmail.com\r\n18davidgarcia@gmail.com\r\nbrandoncdonaldson@gmail.com\r\nandrewbayles1@gmail.com\r\nsolidmagill@gmail.com\r\ndizonjh@gmail.com\r\nalexlinys@hotmail.com\r\nmichaelm1994@msn.com\r\ndominick.canady@comcast.net\r\nhkusakabe@hotmail.com\r\njmou95@gmail.com\r\narmitn@uw.edu\r\nzachbsd@yahoo.com\r\nwessel.24soccer22@gmail.com\r\nelliotvaughn@live.com\r\ntmartinson95@gmail.com\r\ns.b.ruhlen@gmail.com\r\nmaxlaroche95@gmail.com\r\nanipert@gmail.com\r\nsampark1203@gmail.com\r\nzdhall@live.com\r\nza.zilke1@gmail.com\r\nrahulperumal555@gmail.com\r\nDerekcoley@hotmail.com\r\njeremyknight99@gmail.com\r\njkavy@hotmail.com\r\nweiss.exe@gmail.com\r\nmmcook545@gmail.com\r\nCaseyfranks7@hotmail.com\r\najm1994@live.com\r\niantbrodie@gmail.com\r\nmattkelleher96@gmail.com\r\nalec@theazures.com\r\nzavaleta_soccer@hotmail.com\r\nTjo987@hotmail.com\r\nmbteddy@verizon.net\r\nmatthewjwhitaker@msn.com\r\njoshuamielke@gmail.com\r\nxavier.jgardner@yahoo.com\r\nwcho@uw.edu\r\nghutchison5@gmail.com\r\naleccege@gmail.com\r\ntoda.mark@gmail.com\r\noliveralbee@gmail.com\r\nhalfmanrob@aol.com\r\nkennyg152@gmail.com\r\npashakazakov37@gmail.com\r\nchadshapard@gmail.com\r\nhausercurt@yahoo.com\r\nblaismax@gmail.com\r\nsean.j.underwood@gmail.com\r\ndanepollett@gmail.com\r\nmichaelfunky@hotmail.com\r\nseamac824@gmail.com\r\nbrandonterlouw@gmail.com\r\nerikeliason1@gmail.com\r\ndontsendspam2@gmail.com\r\nkevinb9@uw.edu\r\n\r\n1694...\r\n1695\u2026\r\n1696...\r\n1697\u2026\r\n1698...\r\n1699...\r\n1700\u2026\r\n1701\u2026\r\n1702...\r\n1703\u2026\r\n1704\u2026\r\n1705\u2026\r\n1706...\r\n1707...\r\n1708...\r\n1709\u2026\r\n1710\u2026\r\n1711...\r\n1712\u2026\r\n1713...\r\n1714...\r\n1715...\r\n1716...\r\n1717...\r\n1718...\r\n1719\u2026\r\n1720...\r\n1721\u2026\r\n1722...\r\n1723...\r\n1724\u2026\r\n1725...\r\n1726\u2026\r\n1727...\r\n1728\u2026\r\n1729...\r\n1730...\r\n1731\u2026\r\n1732\u2026\r\n1733\r\n1734\u2026\r\n1735...\r\n1736\u2026\r\n1737\u2026\r\n1738...\r\n1739...\r\n1740...\r\n1741...\r\n1742...\r\n1743...\r\n1744...\r\n1745...\r\n1746...\r\n1747...\r\n1748...\r\n1749...\r\n1750...\r\n1751...\r\n1752...\r\n1753...\r\n1754...\r\n1755...\r\n1756...\r\n1757...\r\n1758...\r\n1759...\r\n1760\u2026\r\n1761\u2026\r\n1762\u2026\r\n1763\u2026\r\n1764\u2026\r\n1765\u2026\r\n1766\u2026\r\n1767\u2026\r\n1768\u2026\r\n1769\u2026\r\n1770\u2026\r\n1771\u2026\r\n1772\u2026\r\n1773\u2026\r\n1774\u2026\r\n1775\u2026\r\n1776\u2026\r\n1777\u2026\r\n1778\u2026\r\n1779\u2026\r\n1780\u2026\r\n1781\u2026\r\n1782...\r\n1783...\r\n1784...\r\n1785...\r\n1786...\r\n1787...\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\nPledge\r\n\r\n3605406298\r\n(360)789-3206\r\n3604206852\r\n(253)740-4339\r\n360 630-1171\r\n3607704522\r\n(253)820-5587\r\n(360)540-5375\r\n5306385250\r\n(509)701-1195\r\n(360)581-6601\r\n(425)591-8517\r\n360-421-9893\r\n2069474077\r\n4254229423\r\n(702)738-3416\r\n(360)773-8605\r\n2063003121\r\n(206)715-4095\r\n509-899-4624\r\n3608887989\r\n509-768-0388\r\n360-951-5581\r\n(253) 241-3423\r\n4252896570\r\n(206)280-8259\r\n4257733567\r\n(425)736-0855\r\n3609032653\r\n3603495056\r\n2066695634\r\n2067340232\r\n(425)377-5666\r\n425-244-1899\r\n(682)225-2523\r\n3602817229\r\n2064996329\r\n(425)614-6644\r\n(360)980-2467\r\n206-715-6197\r\n(253)359-5188\r\n2068508866\r\n(206)697-2908\r\n(360)430-0237\r\n3604303450\r\n(630) 441 6378\r\n5096388911\r\n3602202114\r\n3609040446\r\n3604838607\r\n206-384-8482\r\n3605200341\r\n2533301190\r\n206-817-1731\r\n4255770560\r\n2067951608\r\n360.941.0919\r\n(650)504-7749\r\n509 669-0296\r\n4252385534\r\n9515292464\r\n360-609-0686\r\n4255907226\r\n5096304948\r\n3607397980\r\n360-708-6825\r\n3609518840\r\n(206) 462-8426\r\n425-314-4161\r\n4252694503\r\n3607892423\r\n4256814976\r\n425-698-0205\r\n4252330584\r\n3605600411\r\n6504554957\r\n2533500955\r\n4255189370\r\n3609310445\r\n3605675483\r\n3604027575\r\n2062595173\r\n206-979-6346\r\n425-647-7518\r\n425-381-7519\r\n4256148162\r\n2069739305\r\n425 444 5279\r\n4254222063\r\n4254437934\r\n4252445227\r\n4255778612\r\n3602242217\r\n4257802401\r\n253-304-4905\r\n425-922-8466\r\n707-888-8252\r\n360-420-1668\r\n360-202-4967\r\n360-581-6787\r\n310-343-2658\r\n425-233-4158\r\n360-383-7743\r\n206-734-9550\r\n206-669-8555\r\n661-309-7410\r\n425-485-1810\r\n503-724-5117\r\n206-446-8350\r\n425-737-0150\r\n208-870-7803\r\n360-610-5080\r\n425-577-4803\r\n760-846-6110\r\n425-985-6021\r\n425-890-4530\r\n360-707-1687\r\n425-503-0149\r\n360-953-1452\r\n206-669-2776\r\n360-547-3122\r\n425-518-1500\r\n775-857-8757";
        }
    }
}
