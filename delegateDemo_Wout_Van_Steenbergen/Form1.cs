using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace delegateDemo
{
    //1. wat is een delegate?

    // een delegate is een object dat verwijst naar een methode , een beetje zoals een functie pointer in c++ 
    delegate void toonLijstDelegate(List<int> mijnLijst,Form1 frm);

    public partial class Form1 : Form
    {
        //2. Waarvoor worden onderstaande lijsten gebruikt?

        /* om de random getallen in te steken wanneer je op bijhorende knop duwt, 
           de andere list om bij te houden welke childforms er zijn gemaakt.*/
        readonly List<int> randomGetallenLijst = new List<int>();
        public List<Form1> ChildForms = new List<Form1>();

        //3. Leg uit wat een static variabele is? 

        /* een static variabele zorg dat de waarde van de variabele in elke instantie van een class het zelfde blijft
           bv. je hebt een class waar variabele i = 5 instaat en functie die i = i+5 uitvoert. als de variabele i niet static is
           zal wanneer je het eerste opbject van deze class aanmaakt en deze functie uitvoert als uitkomst 10 geven. wanneer je het zelfde 
           doet voor het tweede object van deze class zal opnieuw de uitkomst 10 zijn.
           als variabele i  static is en je doet het zelfde zal de uitkomst niet het zelde blijven maar 10 en 15 omdat als i in het eerste object
           veranderd dit ook in het tweede object van die class is*/
        static int formNummer = 1;
        const int MAX_RANDOMGETALLEN = 10;
        const int MAX_RANDOMWAARDE = 100;

        public Form1()
        {
            InitializeComponent();

            //4. De static int formNummer wordt gebruikt om elke form een volgnummer te geven.
            //Deze staat in de klasse gedefinieerd als 'static int formNummer = 1;'.
            //Hoe komt het dat ondanks die in die declaratie '... = 1' staat elke form toch een 
            //oplopend nummer krijgt? Leg dit grondig uit.

            /*omdat hieronder de waarde van formNummer wordt verhoogd met 1 en 
              omdat deze static is wordt het dus in elke instantie van de class gewijzigd*/
            this.Name = "Form"+formNummer.ToString();
            Form1.formNummer++;
            
            btnVulLijstMetRandomGetallen.Text = "Vul List<int> met " + MAX_RANDOMGETALLEN.ToString() + " randomgetallen";
            
            //5. Wat is het effect van het onderstaande statement op de Form?

            /*je zet de text vanboven op de from hetzelfde als de naam van de form*/
            this.Text = this.Name;
        }

        //6. Wanneer je op de button 'btnMaakNieuweChildForm' klikt dan wordt er een
        //nieuwe childform aangemaakt. Bestudeer grondig de onderstaande method en 
        //omschrijf - in woorden of met een diagram - de stappen die worden
        //uitgevoerd bij het aanmaken van een childform.
        //Leg uit wat de functie is van 'mijnAndereForm', 'OuderForm' en 'ChildForms'. 
        //Geef aan of het over objecten of attributen gaat. Leg uit van welke klasse ze
        //zijn of bij welk object ze horen en omschrijf waarvoor ze gebruikt worden.

       /* - eerst wordt er een new form genaamd mijnAndereForm gemaakt. 
          - daarna krijgt ouderForm de zelfde value als de houdige form omdat dit de parantform is
          en zo wordt de info mee gegeven. 
          - hierna wordt mijnandereForm toegevoegd aan de list van childForms zodat alle childForms ook worden bijgehouden
          - en als laatste wordt mijnAndereForm getoond*/
        private void BtnMaakNieuweChildForm_Click(object sender, EventArgs e)
        {
            Form1 mijnAndereForm = new Form1();
            mijnAndereForm.OuderForm = this;
            ChildForms.Add(mijnAndereForm);
            mijnAndereForm.Show();
        }

        //7. Onderstaande method genereert een aantal randomgetallen. Hoeveel getallen 
        //worden er gegenereerd? Wat is het grootste randomgetal dat kan worden 
        //gegenereerd?

        /*MAX_RANDOMWAARDE is 100 maar het grooste getal dat gegenereerd kan worden is minder dan MAX_RANDOMWAARDE dus is 99*/
        private void BtnVulLijstMetRandomGetallen_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            randomGetallenLijst.Clear();

            for (int i=0; i<MAX_RANDOMGETALLEN; i++)
            {
                randomGetallenLijst.Add(random.Next(0, MAX_RANDOMWAARDE));
            }

            foreach (int i in randomGetallenLijst)
            {
                tbLogText.Text += i + "  ";
            }
            tbLogText.Text += Environment.NewLine;
        }

        //8. Waarvoor wordt het property OuderForm gebruikt?

        /* om de value's  van de houdige form op te slaan en mee te geven aan het childform*/
        private Form1 ouderForm;

        public Form1 OuderForm
        {
            get { return ouderForm; }
            set { ouderForm = value; }
        }

        //9. Je kan de naam van een parent van een childform tonen. Leg uit hoe de onderstaande 
        //method dit realiseert.

        /*als er een ouderForm aanwezig is (not null dus) zal hij een message box uitlezen waarin de naam van de ouderForm wordt getoond
          als er geen aanwezig is betekend dit dus dat dit de bron form is en zal dit worden gezegt in de messageBox*/
        private void BtnToonParentNaam_Click(object sender, EventArgs e)
        {
            if (ouderForm != null)
            {
                MessageBox.Show("De parent van dit child is "+ ouderForm.Name, "aangemaakt vanaf...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dit is een bronform", "aangemaakt vanaf...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //10. Je kan de namen van alle childs van een parent tonen. Leg uit hoe de onderstaande 
        //method dit realiseert.

        /*er wordt gekeken of er iets staat in de list van childForms (childForms.count > 0) en als dit zo is zal hij elk object in deze list de naam er van 
          op het scherm zetten, als er geen objecten in childForms list zit zal hij zeggen dat er dus geen childs zijn*/
        private void BtnToonChildForms_Click(object sender, EventArgs e)
        {
            if (ChildForms.Count>0)
            {
                foreach (Form1 f in ChildForms)
                {
                    tbLogText.Text +="Childform : " + f.Name + Environment.NewLine;
                }
            }
            else
            {
                tbLogText.Text += "Deze parent heeft geen childforms"+Environment.NewLine;
            }
        }

        //11. Onderstaande method toont de random getallen van een child op zijn parent.
        //Dit lijkt een éénvoudige routine, maar schijn bedriegt. Niet elke form heeft immers een parent. 
        //Hoe wordt er bijgehouden of het form een parentform heeft? 
        //
        //Bovendien kan een childform niet zomaar op een parentform gaan
        //schrijven. Er is nog zoiets als thread-safety...Om op een veilige manier data van 
        //een childform naar een parentform te schrijven wordt er gebruik gemaakt van delegates.
        //We hebben dit mechanisme al in de les gezien. Omschrijf voor deze toepassing hoe het
        //delegate-mechanisme zorgt dat data veilig van een childform naar een parentform wordt geschreven

        /*eerst wordt er dus gekeken of er wel een OuderForm is door te kijken of deze niet NULL is
         je geeft de random getallen mee en ook de ouderForm met functie ToonRandomGetallenOpForm 
         in deze functie ga je kijken of er een invoke required is dit is true omdat ouderform.tblogText op een andere thread zit
         dan wordt er een invoke gadaan van delegate waarin opnieuw ToonRandomGetallenOpForm oproept 
         deze invoke "komt toe" op de parant form en gaat ToonRandomGetallenOpForm uitvoeren. omdat we nu op de juiste thread zit gaat 
         invoke required false zijn en gaan we randomGetallen uitlezen*/
        private void BtnToonGetallenOpParent_Click(object sender, EventArgs e)
        {
            if  (ouderForm!=null)
            {
                ToonRandomGetallenOpForm(randomGetallenLijst,ouderForm);
            }
            else
            {
                MessageBox.Show("Dit is een bronform. Het heeft geen ouderform...");
            }
        }

        private void ToonRandomGetallenOpForm(List<int> randomGetallen, Form1 frm)
        {           
            if (frm.tbLogText.InvokeRequired)
            {
                var d = new toonLijstDelegate(ToonRandomGetallenOpForm);
                frm.tbLogText.Invoke(d, new object[] { randomGetallenLijst, frm });
            }
            else
            {
                foreach (int i in randomGetallen)
                {
                    frm.tbLogText.Text += i+"  ";
                }
                frm.tbLogText.Text += Environment.NewLine;
            }
        }

        //12. Onderstaande method toont de random getallen van een parent op al zijn children.
        //Dit lijkt weerom een éénvoudige routine, maar schijn bedriegt. 
        //Ook hier moet er rekening gehouden worden met thread-safety...
        //Om op een veilige manier data van een parentform naar een childform te schrijven wordt er 
        //gebruik gemaakt van delegates. We hebben dit mechanisme al in de les gezien.
        //Omschrijf voor deze toepassing hoe het delegate mechanisme zorgt dat data veilig 
        //van de parentform naar de childforms wordt geschreven.

        /*hier geldt het zelfde als bij vraag 11 alleen gaat er nu niet de ParantForm worden meegegeven met ToonRandomGetallenOpForm
          maar de childForm en dit doet de ParantForm voor elke childForm hij in lijst ChildForms heeft staan*/
        private void BtnToonGetallenOpChild_Click(object sender, EventArgs e)
        {
                foreach(Form1 f in ChildForms)
                {
                    ToonRandomGetallenOpForm(randomGetallenLijst, f);
                }
        }

        //13. Onderstaande method sluit een form. Dat is iets wat met zorg moet gebeuren. Een form kan 
        //immers een parentform en childforms hebben. Referenties daarnaar wil je niet zomaar
        //levend laten...
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Onderstaande lus wordt uitgevoerd wanneer je een willekeurige form sluit.
            //Wat wordt er in deze lus gedaan? 
            //Om dit te testen start je de code op. Form1 opent. Je maakt een Kinder-form Form2 aan. 
            //Vervolgens maak je van Form2 een kinder-form Form3 aan. Sluit dan (met 'x') Form1. 
            //Wat stel je vast?
            
            /*alle andere childforms sluiten mee*/

            //Voer vervolgens onderstaande test uit: maak eerst forms aan volgens onderstaand schema.
            //De -> geeft de parent-child relatie aan. Sluit vervolgens form2. Wat stel je vast?
            //form1 -> form2
            //form1 -> form3
            //form2 -> form4
            //form2 -> form5
            //form4 -> form6
            //form4 -> form7

            /*het is een beetje als domino steentjes waarbij elke child een aftaking is van de parant. 
             wanneer je een parant wegklikt vallen alle domino's vanaf daar, dus alle aftakken gaan dicht maar niet wat er voor staat dus de parant*/ 

            for (var i = 0; i < ChildForms.Count; i++)
            {
                MessageBox.Show(ChildForms[i].Name.ToString() + " wordt gesloten ", "", MessageBoxButtons.OK);
                ChildForms[i].OuderForm = null;
                ChildForms[i].Close();
                //uncomment het onderstaande if-statement eens, run de code en maak van een parentform 
                //een viertal childforms aan. Wat gebeurt er wanneer je de parent verwijderd?
                //Hoe kan je ervoor zorgen dat jouw toepassing toch gecontroleerd kan worden gesloten?

                /*de message box zegt dat de forms zijn gesloten maar deze zijn nog niet gesloten*/ 

                //if (i == 2) throw (new ArgumentNullException());
            }

            ChildForms.Clear();

            //Waarom is bij het sluiten van een Form het onderstaande if-statement
            //noodzakelijk? 
            //Om dit te testen start je de code op. Form1 opent. Je maakt een Kinder-form Form2 aan. 
            //Vervolgens maak je van Form2 een kinder-form Form3 aan. Sluit dan (met 'x') Form2. 
            //Wat stel je vast?

            /*wanneer de parant niet de bron parant is moet hij bij een andere parant in de childForms List staan maar wanneer hij
             wordt gesloten moet hij dus bij die parant uit die lijst verdwijnen. de code in de if statement zorgt hiervoor.*/

            if (OuderForm != null)
            {
                var geslotenForm = sender as Form1;
                MessageBox.Show(geslotenForm.Name.ToString() + " wordt verwijderd uit lijst ChildForms van " + OuderForm.Name.ToString());
                OuderForm.ChildForms.Remove(geslotenForm);
            }
        }

        //14. een makkelijke...wat doet de onderstaande method?

        /*het verwijderd alles uit tbLogText*/
        private void BtnClearLogText_Click(object sender, EventArgs e)
        {
            tbLogText.Clear();
        }
    }
}
