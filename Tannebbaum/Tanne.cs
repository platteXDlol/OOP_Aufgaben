using System.Text;

namespace Tannebbaum
{
    public class Tanne
    {
        public int Stammbreite { get; set; }
        public int Stammhoehe { get; set; }
        public int Kronenhoehe { get; set; }
        public string Zeichnung { get; private set; }

        public void Zeichne()
        {
            StringBuilder sb = new();
            for (int i = 0; i < Kronenhoehe; i++)
            {
                sb.Append(' ', Kronenhoehe - i - 1);
                sb.Append('*', 2 * i + 1);
                sb.AppendLine();
            }
            for (int i = 0; i < Stammhoehe; i++)
            {
                sb.Append(' ', Kronenhoehe - Stammbreite / 2);
                sb.Append('*', Stammbreite);
                sb.AppendLine();
            }
            Zeichnung = sb.ToString();
        }
    }
}