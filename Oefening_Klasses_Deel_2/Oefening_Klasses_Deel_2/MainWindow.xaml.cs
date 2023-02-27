using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary;

namespace Oefening_Klasses_Deel_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Artikel> artikels = new List<Artikel>();
        int artikelIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            VulArtikelLijst();

        }

        private void VulArtikelLijst()
        {
            Artikel art1 = new Artikel(
                "16 Februari 2023",
                "./Assets/bing.jpg",
                "Last week, after testing the new, A.I.-powered Bing search engine from Microsoft, I wrote that, much to my shock, it had replaced Google as my favorite search engine.\r\n" +
                "\r\nBut a week later, I’ve changed my mind. I’m still fascinated and impressed by the new Bing, and the artificial intelligence technology (created by OpenAI, the maker of ChatGPT) that powers it. But I’m also deeply unsettled, even frightened, by this A.I.’s emergent abilities.\r\n" +
                "\r\nIt’s now clear to me that in its current form, the A.I. that has been built into Bing — which I’m now calling Sydney, for reasons I’ll explain shortly — is not ready for human contact. Or maybe we humans are not ready for it.\r\n" +
                "\r\nThis realization came to me on Tuesday night, when I spent a bewildering and enthralling two hours talking to Bing’s A.I. through its chat feature, which sits next to the main search box in Bing and is capable of having long, open-ended text conversations on virtually any topic.\r\n" +
                " (The feature is available only to a small group of testers for now, although Microsoft — which announced the feature in a splashy, celebratory event at its headquarters — has said it plans to release it more widely in the future.)",
                "Kevin Roose",
                "A Conversation With Bing’s Chatbot Left Me Deeply Unsettled"
                );

            // 3 nieuwe artikels worden gemaakt en in de lijst gestoken
            Artikel art2 = new Artikel(
                "12 Februari 2023",
                "./Assets/corona.jpeg",
                "The World Health Organization (WHO) has quietly shelved the second phase of its much-anticipated scientific investigation into the origins of the COVID-19 pandemic, citing ongoing challenges over attempts to conduct crucial studies in China, Nature has learned.\r\n" +
                "\r\nResearchers say they are disappointed that the investigation isn’t going ahead, because understanding how the coronavirus SARS-CoV-2 first infected people is important for preventing future outbreaks. But without access to China, there is little that the WHO can do to advance the studies, says Angela Rasmussen, a virologist at the University of Saskatchewan in Saskatoon, Canada. “Their hands are really tied.”\r\n" +
                "\r\nIn January 2021, an international team of experts convened by the WHO travelled to Wuhan, China, where the virus that causes COVID-19 was first detected. Together with Chinese researchers, the team reviewed evidence on when and how the virus might have emerged, as part of phase one. The team released a report in March that year outlining four possible scenarios, the most likely being that SARS-CoV-2 spread from bats to people, possibly through an intermediate species. Phase one was designed to lay the groundwork for a second phase of in-depth studies to pin down exactly what happened in China and elsewhere.",
                "Smriti Mallapaty",
                "WHO abandons plans for crucial second phase of COVID-origins investigation"
                );

            Artikel art3 = new Artikel(
                "14 Februari 2023",
                "I remember the first time I took note of the balaclava. It was a little over a year ago, at a crowded house party in deep Brooklyn. A lanky, twenty-something man wore a bright orange balaclava—despite the tropical microclimate created by all the packed, dancing bodies. He took nonchalant sips from a red Solo cup, mesmerizingly comfortable in his anonymity. \r\n" +
                "\r\nAt that time, I viewed the moment as eccentric and kooky. Who wears a balaclava if they’re not in the arctic or planning a heist? Though balaclavas—also known as ski masks—have been popular for a long time in frigid locales such as Eastern and Northern Europe, they weren’t as common in a city like New York. But perhaps their relative out-of-placeness is what made them a great candidate for trend-forward New York style. Colorful, striped balaclavas like the ones sold by Marni and Ella Emhoff catches your eye, but also obscures the identity of the wearer. It places all your attention on the clothes, not the person. ",
                "André-Naquian Wheeler",
                "All the Cool Kids Are Wearing Balaclavas"
                );

            artikels.Add(art1);
            artikels.Add(art2);
            artikels.Add(art3);

        }

        private void BtnVolgende_Click(object sender, RoutedEventArgs e)
        {
            if (artikelIndex < artikels.Count-1) artikelIndex++;
            else artikelIndex = 0;
            LaadArtikel(artikels[artikelIndex]);
        }

        private void BtnVorige_Click(object sender, RoutedEventArgs e)
        {
            if (artikelIndex > 0) artikelIndex--;
            else artikelIndex = 2;
            LaadArtikel(artikels[artikelIndex]);
        }

        private void LaadArtikel(Artikel artikel)
        {
            TxtTitel.Text = artikel.Titel;
            TxtInhoud.Text = artikel.Inhoud;
            TxtNaamJournalist.Text = artikel.Journalist;
            TxtDatumPublicaties.Text = artikel.DatumVanPublicatie;
            if (artikel.ImagePath.Length > 0)
            {
                BitmapImage img = new BitmapImage();
                img.UriSource = new Uri(artikel.ImagePath, UriKind.Relative);

                ImgArticle.Source = img;
            }
        }

    }
}
