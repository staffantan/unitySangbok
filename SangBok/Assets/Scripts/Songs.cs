using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Songs {

    public enum SongType{
        Klassiskt,
        Öl,
        Punsch,
        Nubbe,
        Vin,
        Kräftor,
        Bakfylla,
        Odödliga,
        Nördigt,
		Ekivoka,
		Nedladdade,
		Egna
    }

    public static List<Song> GetAllSongs(SongType type)
    {
        var songs = new List<Song>();

        if (type == SongType.Klassiskt)
        {
            /* KLASSISKT */
            songs.Add(new Song(
                    "Nationalsången",
                    "Melodi: Så rider jag mig över tolvmilan skog",
                    "Text: Richard Dybeck",
                    "Du gamla, Du fria, Du fjällhöga nord\nDu tysta, Du glädjerika sköna!\nJag hälsar Dig, vänaste land uppå jord,\n||: Din sol, Din himmel, Dina ängder gröna. :||\n\nDu tronar på minnen från fornstora dar,\ndå ärat Ditt namn flög över jorden.\nJag vet att Du är och Du blir vad Du var.\n||: Ja, jag vill leva jag vill dö i Norden. :||\n\nJag städs vill Dig tjäna mitt älskade land,\nDin trohet till döden vill jag svära.\nDin rätt, skall jag värna, med håg och med hand,\n||: Din fana, högt den bragderika bära. :||\n\nMed Gud skall jag kämpa, för hem och för härd,\nför Sverige, den kära fosterjorden.\nJag byter Dig ej, mot allt i en värld.\n||: Nej, jag vill leva jag vill dö i Norden. :||",
                    "Sången är skriven till den västmanländska folkmelodin 'Så rider jag mig över tolvmilan skog...' och framfördes första gången vid Dybecks första 'aftonunderhållning med nordisk folkmusik' i Stockholm den 18 november 1844. Då började sången 'Du gamla, Du friska' men detta ändrades senare. Sången kom med tiden att betraktas som Sveriges nationalsång."));

            songs.Add(new Song(
                    "Gustafs Skål",
                    "",
                    "Text: Carl Michael Bellman",
                    "||: Gustafs skål!\nDen bäste Kung, som Norden äger: \nHan ej tål,\nAt vigtskåln ojämt väger. :|| \n||: God och glad,\n\nHan Ilskans röst föraktar \nSamt afvaktar\nOch betraktar\nDårskap i sin grad. :||\n\n||: Sådan Kung\när värd att styra Sveriges öden:\nRask och ung,\nEj rådlös uti nöden. :||\n\n||: Wasa ätt\nHar aldrig lärt att svika, \nAldrig tvika,\nMen at fika\nTill at göra rätt. :||",
                    "Sveriges första nationalsång. Blev allmänt känd efter Gustaf III:s statskupp den 19 augusti 1772, men komponerades sannolikt tidigare."));

            songs.Add(new Song(
                    "Kungssången",
                    "Melodi: Otto Lindblad",
                    "Text: Carl Vilhelm August Strandberg",
                    "Ur svenska hjärtans djup en gång\nen samfälld och en enkel sång,\nsom går till kungen fram!\nVar honom trofast och hans ätt,\ngör kronan på hans hjässa lätt,\noch all din tro till honom sätt,\ndu folk av frejdad stam!\n\nO konung, folkets majestät\när även ditt. Beskärma det\noch värna det från fall!\nStå oss all världens härar mot,\nvi blinka ej för deras hot,\nvi lägga dem inför din fot,\nen kunglig fotapall.\n\nMen stundar ock vårt fall en dag,\nfrån dina skuldror purpurn tag,\nlyft av dig kronans tvång\noch drag de kära färger på,\ndet gamla gula och det blå,\noch med ett svärd i handen gå\ntill kamp och undergång!\n\nOch grip vår sista fana du\noch dristeliga för ännu\ni döden dina män!\nDitt trogna folk med hjältemod\nskall sömma av sitt bästa blod\nen kunglig purpur varm och god,\noch svepa dig i den.\n\nDu himlens herre, med oss var,\nsom förr du med oss varit har,\noch liva på vår strand\ndet gamla lynnets art igen\nhos sveakungen och hans män.\nOch låt din ande vila än\nutöver nordanland!",
                    "Framfördes första gången i Lund den 5 december 1844."));

            songs.Add(new Song(
                    "Här är gudagott att vara",
                    "",
                    "Text: Gunnar Wennerberg",
                    "Här är gudagott att vara.\nO, vad livet dock är skönt.\nHör vad fröjd från fåglars skara,\nSe vad gräset lyser grönt.\nHumlan surrar, fjäriln prålar,\nLärkan slår i skyn sin drill\nOch ur nektarfyllda skålar\nDricka oss små blommor till.",
                    "Glunt nr 25. Ur 'Examens-sexa på Eklundshof', skriven 1848 när Glunten slutligen tog examen."));

            songs.Add(new Song(
                    "Sveriges flagga",
                    "Melodi: Hugo Alfvén",
                    "Text: Karl Gustav Ossiannilsson",
                    "Flamma stolt mot dunkla skyar\nlik en glimt av sommarens sol!\növer Sveriges skogar, berg och byar,\növer vatten av viol!\nDu som sjunger, när Du bredes\nsom vår gamla lyckas tolk.\nSolen lyser! Solen lyser! \nIngen vredes åska slog vårt tappra folk! \n\nFlamma högt vårt kärlekstecken!\nVärm oss, när det blåser kallt!\nStråla ut de blåa vecken\nkärlek mera stark än allt!\nSveriges flagga! Sveriges ära!\nFornklenod och framtidstolk!\nGud är med oss! Gud är med oss!\nHan skall bära stark vårt fria svenska folk!",
                    "Framfördes första gången på Stockholms Stadion den 6 juni 1916, under ledning av Hugo Alfvén."));

            songs.Add(new Song(
                    "Studentsången",
                    "Melodi: Prins Gustaf",
                    "Text: Herman Sätherberg",
                    "Sjung om studentens lyckliga dag\nlåtom oss fröjdas i ungdomens vår!\nän klappar hjärtat med friska slag,\noch den ljusnande framtid är vår.\nInga stormar än,\ni våra sinnen bo.\nHoppet är vår vän,\noch vi dess löften tro,\nnär vi knyta förbund i den lund,\ndär de härliga lagrarna gro,\ndär de härliga lagrarna gro!\n\nSvea, vår moder, hugstor och skön,\nmanar till bragd som i forntida dagar.\nVinkar med segerns och ärans lön,\nmen den skörd utan strid man ej tar.\nAldrig slockne då,\nkänslornas rene brand.\nAldrig brista må,\nvår trohets helga band,\nså i gyllene frid som i strid:\nLiv och blod för vårt fädernesland!\nLiv och blod för vårt fädernesland!",
                    "Marschen komponerades troligen 1851, året innan sångarprinsen dog. Texten skrevs något år senare."));

            songs.Add(new Song(
                    "Frans Mikael Franzéns dryckesvisa",
                    "Melodi: Olof Åhlström",
                    "Text: Biskop Frans Mikael Franzén",
                    "När skämtet tar ordet vid vänskapens bord\nmed fingret kring glasen som dofta.\nSå drick och var glad, på vår sorgliga jord\nman gläder sig aldrig för ofta.\nTy en blomma är glädjen, i dag slår hon ut,\ni morgon förvissnar hon redan.\nJust nu, när du kan, hav en lycklig minut,\noch tänk på det kommande sedan.\n\nVem drog ej en suck över tidernas lopp?\nDock sitt ej och dröm på kalaset!\nHär lev i sekunden och hela ditt hopp\nse fyllas och tömmas i glaset.\nHär sörj ej för glaset, om fullt, så drick ut.\nOm tomt, så försänd det att fyllas!\nOch minns allt det sköna och goda förut\nsen gädjen och nöjet må hyllas.\n\nTy ägne vi först åt värdinnan en skål:\nvad vore vår fröjd utan henne?\nSen prise vi värden och särskilt hans bål:\nvad vore vårt mod utan denne?\nDem båda förene ett glas och en sång,\nde själva så skönt sig förente.\nMed druvorna myrten blev skapt på en gång:\nvem ser ej, vad himmelen mente?\n\nFör övrigt må värden ge alltid nytt skäl\ntill ständig omsättning av glasen\noch visa att rangen är nyttig likväl\ntill skålarnas mängd vid kalasen.\nMen förr'n han är färdig med klang och harang\nvi skynde att självmante dricka\noch helge ett glas, som är över all rang\ni tysthet en var åt sin flicka.",
                    "Texten publicerades den 4 februari 1807 i Åbo Tidning, året innan Franzén valdes in i Svenska Akademien."));

            songs.Add(new Song(
                    "Sverige",
                    "Melodi: Wilhelm Stenhammar",
                    "Text: Verner von Heidenstam",
                    "Sverige, Sverige, Sverige fosterland\nVår längtans bygd, vårt hem på jorden.\nNu spelar källorna, där härar lysts av brand,\noch dåd blev saga, men med hand vid hand\nsvär än ditt folk som förr de gamla trohetsorden.\nFall julesnö och susa djupa mo!\nBrinn österstjärna genom junikvällen!\n\nSverige, moder! Bliv vår strid, vår ro,\ndu land där våra barn en gång få bo\noch våra fäder sova under kyrkohällen!",
                    "Komponerad 1905."));

            songs.Add(new Song(
                    "O gamla klang- och jubeltid",
                    "Melodi: O alte Burschenherrlichkeit",
                    "Text: August Lindh",
                    "O gamla klang- och jubeltid\nditt minne skall förbliva\noch än åt livets bistra strid,\nett rosigt skimmer giva.\nSnart tystnar allt vårt yra skämt,\nvår sång blir stum, vårt glam förstämt.\nO, jerum, jerum, jerum.\nO, quae mutatio rerum!\n\nVar äro de som kunde allt,\nblott ej sin ära svika.\nSom voro män av äkta halt\noch världens herrar lika?\nDe drogo bort från vin och sång\ntill vardagslivets tråk och tvång.\nO, jerum...\n\nDen ene vetenskap och vett\nin i scholares mänger,\nDen andre i sitt anlets svett\npå paragrafer vränger,\nen plåstrar själen, som är skral,\nen lappar hop dess trasiga fodral;\nO, jerum...\n\nMen hjärtat i en sann student,\nkan ingen tid förfrysa.\nDen glädjeeld, som där han tänt,\nhans hela liv skall lysa.\nDet gamla skalet brustit har\nmen kärnan finnes frisk dock kvar,\noch vad han än må mista,\nden skall dock aldrig brista!\n\nSå sluten, bröder, fast vår krets,\ntill glädjens värn och ära!\nTrots allt vi tryggt och väl tillfreds\nvår vänskap trohet svära.\nLyft bägarn högt och klinga vän!\nDe gamla gudar leva än\nbland skålar och pokaler,\nbland skålar och pokaler!",
                    "Melodin och refrängen 'O, jerum...' är ursprungligen från den tyska visan 'Was fang ich armer Teufel an' skriven av Jenaer Blatt 1763. Till denna melodi skrev Eugen Höfling sin nya text 1825, vilken den tidigare uppsalastudenten August Lindh översatte till Västmanlands-Dala nations första sångbok 1921. Angående refrängen: Jerum är en omskrivning för Jesus. Quae mutatio rerum betyder 'vilken sakernas förändring', alltså betyder refrängen 'O jösses, vilken förändring!' Den latinska diftongen ae, som romarna uttalade 'aj', har under medeltiden och framåt vanligen har uttalats som 'ä'. Sjungen av svenskar bör ordet quae uttalas 'kvä'."));

            songs.Add(new Song(
                    "O alte Burschenherrlichkeit",
                    "",
                    "Text: Eugen Höfling",
                    "O alte Burschenherrlichkeit,\nWohin bist du entschwunden,\nNie kehrst du wieder gold'ne Zeit,\nSo froh und ungebunden!\nVergebens spähe ich umher,\nIch finde deine Spur nicht mehr.\nO jerum, jerum, jerum,\nO quae mutatio rerum.\n\nDen Burschenhut bedeckt der Staub,\nEs sank der Flaus in Trümmer,\nDer Schläger ward des Rostes Raub,\nErblichen ist sein Schimmer.\nVerklungen der Kommersgesang,\nVerhallt Rapier- und Sporenklang.\nO jerum...\n\nWo sind sie, die vom breiten Stein\nNicht wankten und nicht wichen,\nDie ohne Moos bei Scherz und Wein,\nDem Herrn der Erde glichen?\nSie zogen mit gesenktem Blick\nIn das Philisterland zurück.\nO jerum...\n\nDa schreibt mit finsterem Amtsgesicht\nDer eine Relationen.\nDer andere seufzt beim Untericht,\nUnd der macht Rezensionen;\nDer schilt die sünd'ge Seele aus\nUnd der flickt ihr verfallnes Haus.\nO jerum...\n\nAuf öder Strecke schraubt und spannt\nDas Fadenkreuz der eine,\nDer andre seufzt beim Blockverband,\nUnd der setzt Ziegelsteine;\nDer kocht aus Rüben Zuckersaft\nUnd der aus Wasser Pferdekraft.\nO jerum...\n\nZur Börse schnell der eine rennt,\nZu tät'gem Geschäfte,\nDer andre sitzt beim Kontokorrent\nUnd der nützt fremde Kräfte;\nDer importiert aus Turkestan\nUnd der bohrt seine Schuldner an.\nO jerum...\n\nAllein das rechte Burschenherz\nKann nimmermehr erkalten,\nIm Ernste wird, wie hier im Scherz,\nDer rechte Sinn stehts walten;\nDie alte Schale nur ist fern,\nGeblieben ist uns doch der Kern,\nUnd den lasst fest uns halten, \nUnd den lasst fest uns halten.\n\nD'rum Freunde reichet euch die Hand,\nDamit es sich erneue,\nDer alten Freundschaft heil'ges Band,\nDas alte Band der Treue.\nKlingt an und hebt die Gläser hoch,\nDie alten Burschen leben noch,\nNoch lebt die alte Treue,\nNoch lebt die alte Treue.",
                    ""));

            songs.Add(new Song(
                    "Nu grönskar det",
                    "Melodi: Johann Sebastian Bach, ur Bondekantaten",
                    "Text: Evelyn Lindström",
                    "Nu grönskar det i dalens famn\nnu doftar äng och lid.\nKom med, kom med på vandringsfärd\ni vårens glada tid!\nVar dag är som en gyllne skål\ntill brädden fylld med vin.\nSå drick, min vän, drick sol och\ndoft, ty dagen, den är din!\n\nLångt bort från stadens gråa hus\nvi glatt vår kosa styr\noch följer vägens vita band\nmot ljusa äventyr.\nMed öppna ögon låt oss se\npå livets rikedom,\nsom gror och sjuder överallt\ndär våren går i blom.",
                    ""));

            songs.Add(new Song(
                    "Den blomstertid nu kommer",
                    "",
                    "Text: Israel Kolmodin",
                    "Den blomstertid nu kommer\nmed lust och fägring stor.\nDu nalkas ljuva sommar,\ndå gräs och gröda gror.\nMed blid och livlig värma\ntill allt, som varit dött.\nSig solens strålar närma,\noch allt blir återfött.\n\nDe fagra blomsterängar\noch åkerns ädla säd,\nde rika örtesängar\noch lundens gröna träd.\nDe skola oss påminna\nGuds godhets rikedom,\natt vi den nåd besinna,\nsom räcker året om.\n\nMan hörer fåglar sjunga\nmed mångahanda ljud,\nskall icke då vår tunga\nlovsäga Herren Gud?\nMin själ, upphöj Guds ära\nstäm upp din glädjesång\ntill den som vill oss nära\noch fröjda på en gång.",
                    "Psalm 199. Skrevs 1694 under Kolmodins tid som biskop i Visby och hette från början 'En sommarwisa'."));

            songs.Add(new Song(
                    "De brevitate vitae",
                    "",
                    "Text: Christian Wilhelm Kindleben",
                    "||: Gaudeamus igitur, juvenes dum sumus! :||\nPost jucundam juventutem,\npost molestam senectutem\n||: nos habebit humus. :||\n||: Ubi sunt, qui ante nos in mundo fuere? :||\nVadite ad superos,\ntransite ad inferos!\n||: Ubi jam? Fuere! :||\n||: Vita nostra brevis est brevi finietur. :||\nVenit mors velociter,\nrapit nos atrociter,\n||: nemini parcetur. :||\n||: Vivat academia, vavant professores, :||\nVivat membrum quodlibet,\nvivant membra quaelibet,\n||: semper sin in flore! :||\n||: Vivant omnes virgines faciles, formosae! :||\nVivant et mulieres\ntenerae, amabiles,\n||: bonae, loboriosae! :||\n||: Vivat et respublica et qui illam regit! :||\nVivat nostra civitas,\nmaecenatum caritas,\n||: quae nos hic protegit! :||\n||: Pereat tristia, pereant osores! :||\nPereat diabolus,\nquivis antiburschius,\n||: atque irrisores! :||",
                    "Återgår på en redan 1267 känd visa, tillskriven biskop Strada i Bologna. Sin nuvarande form har sången fått av studentskalden Kindleben i Halle 1781."));

            songs.Add(new Song(
                    "Längtan till landet",
                    "Melodi: Otto Lindblad",
                    "Text: Herman Sätherberg",
                    "Vintern rasat ut bland våra fjällar,\ndrivans blommor smälta ner och dö.\nHimlen ler i vårens ljusa kvällar,\nsolen kysser liv i skog och sjö.\nSnart är sommarn här i purpurvågor,\nguldbelagda, azurskiftande\nligga ängarne i dagens lågor\noch i lunden dansa källorne.\n\nJa, jag kommer! Hälsen, glada vindar,\nut till landet, ut till fåglarne,\natt jag älskar dem till björk och lindar,\nsjö och berg, jag vill dem återse.\nSe dem än som i min barndoms stunder,\nfölja bäckens dans till klarnad sjö,\ntrastens sång i furuskogens lunder,\nvattenfågelns lek kring fjärd och ö.",
                    "Från 'Jägarens hvila. Poetiska bilder från skogen, fältet och sjön', 1838. Har egentligen ytterligare fyra verser."));

            songs.Add(new Song(
                    "Vårvindar friska",
                    "",
                    "Text: Julia Kristina Nyberg alias Euphrosyne",
                    "Vårvindar friska, leka och viska\nlunderna kring, likt älskande par.\nStrömmarna ila, finna ej vila,\nförrän i havet störtvågen far.\nKlappa mitt hjärta, klaga och hör,\nvallhornets klang bland klipporna dör.\nStrömkarlen spelar, sorgerna delar\nvakan kring berg och dal.\n\nHjärtat vill brista, ack, när den sista\ngången jag hörde kärlekens röst.\nögonens låga, avskedets plåga,\nmun emot mun och klappande bröst.\nFjälldalen stod i grönskande skrud.\nTrasten slog drill på drill för sin brud.\nStrömkarlen spelar, sorgerna delar\nvakan kring berg och dal.",
                    "Ursprunglig titel 'Den stackars Anna eller Moll-toner från Norrland'. Originalet har ytterligare fyra verser och skrevs på 1830-talet."));

            songs.Add(new Song(
                    "Uti vår hage",
                    "",
                    "",
                    "Uti vår hage där växa blå bär.\nKom hjärtans fröjd!\nVill du mig något, så träffas vi där.\nKom liljor och akvileja,\nkom rosor och saliveja,\nkom ljuva krusmynta,\nkom hjärtans fröjd!\n\nFagra små blommor där bjuda till dans.\nKom hjärtans fröjd!\nVill du så binder jag åt dig en krans.\nKom liljor...\n\nKransen den sätter jag sen i ditt hår.\nKom hjärtans fröjd!\nSolen den dalar men hoppet uppgår.\nKom liljor...\n\nUti vår hage finns blommor och bär.\nKom hjärtans fröjd!\nMen utav alla du kärast mig är.\nKom liljor...",
                    "Text och melodi av traditionellt gotländskt ursprung Växterna som nämns har eventuellt ingått i ett medeltida abortmedel. Sången blev allmänt känd genom Hugo Alfvén vars arrangemang framfördes första gången vid en Orphei Drängar-konsert i Stockholm 1918."));

            songs.Add(new Song(
                    "Majsång",
                    "Melodi: Lars Magnus Béen",
                    "Text: Johan Ludvig Runeberg",
                    "Sköna maj, välkommen\ntill vår bygd igen!\nSköna maj, välkommen,\nvåra lekars vän!\nKänslans gudaflamma\nväcktes vid din ljusning;\njord och skyar stamma\nkärlek och förtjusning;\nsorgen flyr för våren,\nglädje ler ur tåren,\nmorgonrodnad ur bekymrens moln.\n\nBlomman låg förkolnad\nunder frost och snö;\nhöstens bleka vålnad,\ngick hon nöjd att dö.\nVintern, härjarns like,\nsom föröder nejden\noch i skövlat rike\ntronar efter fejden,\nsatt med isad glaven\nsegrande på graven,\ndyster själv och mörk och kall som den.\n\nInga strålar sänktes\npå vår morgon ner,\ningen daggtår skänktes\nnordens afton mer,\ntills, av svaner dragen,\nmaj med blomsterhatten\ngöt sitt guld i dagen,\npurpurklädde natten,\nvinterns spira bräckte\noch ur lossat häkte\nkallade den väna Flora fram.\n\nNu ur lundens sköte\noch ur blommans knopp\nstiga dig till möte\nglada offer opp.\nBlott ditt lov de susa,\ndessa rosenhäckar,\ntill din ära brusa\nvåra silverbäckar,\noch med tacksam tunga\ntusen fåglar sjunga\nliksom vi: Välkommen, sköna maj!",
                    ""));

            songs.Add(new Song(
                    "En vänlig grönskas rika dräkt",
                    "Melodi: Waldemar Åhlén",
                    "Text: Carl David af Wirsén",
                    "En vänlig grönskas rika dräkt\nhar smyckat dal och ängar.\nNu smeker vindens ljumma fläkt\nde fagra örtesängar,\noch solens ljus och lundens sus\noch vågens sorl bland viden\nförkunna sommartiden.\n\nSin lycka och sin sommarro\nde yra fåglar prisa.\nUr skogen snår, ur stilla bo\nframklingar deras visa.\nEn hymn går opp, med fröjd och hopp\nfrån deras glada kväden,\nbland blommorna och träden.\n\nMen du, o Gud som gör vår jord\nså skön i sommarns stunder,\nGiv, att jag aktar främst ditt ord\noch dina nådestunder.\nAllt kött är hö, och blomstren dö\noch tiden allt fördriver.\nBlott Herrens ord förbliver.",
                    "Psalm 201. Publicerades urprungligen i 'Kristna högtids- och helgdagar' 1889. Tonsattes 1933 inför en skolavslutning."));
        }

        if (type == SongType.Nubbe)
        {

            /* NUBBE, M.M. */
            songs.Add(new Song(
                "Portos visa",
                "Melodi: You can't get a man with a gun",
                "Text: Tord Andrén",
                "Jag vill börja gasqua\nvar fan är min flaska?\nVem i helvete stal min butelj?\nSkall törsten mig tvinga\nen TT börja svinga?\nNej, för fan, bara blunda och svälj.\nVilken smörja!\nFår jag spörja:\nVem, för fan, tror att jag är en älg?\n\nTill England vi rider,\noch sedan vad det lider\nträffar vi välan på någon pub.\nOch där skall vi festa,\nblott dricka av det bästa\nutav whisky och portvin.\nJag tänker gå hårt in\nför att pröva på rubb och stubb.\n",
                "Från Bergsspexet 'De fyra musketörerna' 1959. Bestämda bergsmän hävdar att visan ursprungligen hette 'Athos visa'."));

            songs.Add(new Song(
                    "Jag har aldrig var't på snusen",
                    "Melodi: Åh, hur saligt att få vandra",
                    "",
                    "Jag har aldrig var't på snusen\naldrig rökat en cigarr, halleluja!\nMina dygder äro tusen,\ninga syndiga laster jag har.\nJag har aldrig sett nå't naket,\ninte ens ett litet nyfött barn.\nMina blickar går mot taket,\ndärmed undgår jag frestarens garn.\n\n||: Halleluja, halleluja. :||\n\nBacchus spelar på gitarren,\nSatan spelar på sitt handklaver.\nAlla djävlar dansar tango,\nsäg, vad kan man väl önska sig mer?\nJo, att alla bäckar vore brännvin,\nRiddarfjärden full av bayerskt öl,\nkonjak i varenda rännsten\noch punsch i varendaste pöl.\n\n||: Och mera öl, och mera öl. :||",
                    ""));

            songs.Add(new Song(
                    "Gums visa",
                    "",
                    "",
                    "||: Skål kamrater, ty livet är glatt,\noch snart förgäta vi sorgen.\nVi söpo igår, vi supa idag\noch vi tar en sjujäkel i morgon. :||\nSkål, skål, skål, skååål.\n",
                    ""));

            songs.Add(new Song(
                    "Handelsvisa",
                    "Melodi: Åh, hur saligt att få vandra",
                    "",
                    "Jag vill aldrig gå på Handels,\naldrig tenta företagsekonomi.\nDeras IQ den e' Mandels\noch förståndet, det har gjort sorti.\nDom har jätteusla snören,\ntill sitt jättefula draperi.\nDom kan bara räkna ören,\nhela Handels e' ett djävla aperi!\n\n||: Handels är skit, jag vill ej dit. :||\n\nMammons gossar är dom alla,\npappas flickor är dom likaså,\ngår och tror att dom är balla,\nfastän dom inget alls kan förstå.\nHela Handels borde rivas,\ndetta tycker hela vårat lag.\nDå så skulle Razor trivas\nuppå denna Handels ljuva domedag!\n\n||: Åh, vilket drag, på denna dag. :||",
                    "Skriven av Team kangaroo till Gerhards-gasque, Fysik KTH, 1977"));

            songs.Add(new Song(
                    "Jag vill inte gå på Fysik",
                    "Melodi: Åh, hur saligt att få vandra",
                    "",
                    "Jag vill inte gå på Fysik,\naldrig tenta termometerdynamik.\nJag vill inte höra syntmusik,\ninte festa som en tråkig mattegeek.\nVi ser ut som Televerket\ni vår jättefula overall.\nvi kan bara räkna kvarkar,\noch nu hyllar vi Data med en skål!\n\n||: Fysik är torrt, jag vill ju bort. :||\n\nEinsteins gossar är vi alla,\nHandels flickor kan vi aldrig få.\nGår och tror att vi har ballar,\nmen det får bli för egen hand om det ska gå.\nNu ska hela Sing-Sing rivas,\narkitekt är med på Datas lag,\nTeleverket ska fördrivas\nuppå Konsulatets ljuva domedag\n\n||: Å nubbedrag, på denna dag. :||",
                    "Gemensamt förkör inför en marskalkssittning på Lärarhögskolan hösten 2000 ledde till att Datasektionen skrev spexet som Fysiksektionen sedan framförde."));

            songs.Add(new Song(
                    "Härjarevisan",
                    "Melodi: Gärdebylåten",
                    "Text: Hans Alfredson",
                    "Liksom våra fäder, vikingarna i Norden\ndrar vi landet runt och super oss under borden.\nBrännvinet har blitt ett elixir för kropp såväl som själ.\nKänner du dig liten och ynklig på jorden,\nväxer du med supen och blir stor uti orden,\nslår dig för ditt håriga bröst och blir en man från hår till häl.\n\nJa, nu skall vi ut och härja,\nsupa och slåss och svärja,\nbränna röda stugor, slå små barn och säga fula ord:\nFy fan! (Alternativt 'KTH!' eller så.)\nMed blod skall vi stäppen färga,\nnu änteligen lär jag\nkunna dra nån verklig nytta av\nmin Hermodskurs i mord.\n\nHurra, nu ska vi äntligen få röra på benen\nhela stammen jublar och det spritter i grenen.\nTänk, att än en gång få spränga fram på Brunte i galopp.\nDin doft, o kära Brunte, är trots brist i hygienen\nför en vild mongol minst lika ljuv som syrenen.\nTänk att på din rygg få rida runt i stan och spela topp.\n\nJa, nu skall vi ut och härja...\n\nJa, mordbränder är klämmiga, ta fram fotogenen,\neftersläckningen tillhör just de fenomenen\ninom brandmansyrket som jag tycker det är nån nytta med.\nJag målar för mitt inre upp den härliga scenen:\nblodrött mitt i brandgult. Ej ens prins Eugen en\nlika mustig vy kan måla, ens om han målade med sked.\n\nJa, nu skall vi ut och härja...",
                    "Ur Lundaspexet 'Djinghis Khan' 1954."));

            songs.Add(new Song(
                    "Auld Lang Syne",
                    "Melodi: Scottish Air",
                    "Text: Robert Burns",
                    "Should auld acquaintance be forgot,\nand never brought to mind?\nShould auld acquaintance be forgot,\nand days of auld lang syne?\n\n||: For auld lang syne my dear,\nfor auld lang syne:\nWe'll take a cup o'kindness yet,\nfor auld lang syne. :||\n\nAnd there's a hand my trusty friend,\nand gie's a hand o'thine.\nWe'll take a right gude willing draught,\nfor auld lang syne.\n\n||: For auld... :||",
                    ""));
            songs.Add(new Song(
                    "Our Family",
                    "Melodi: My Bonnie",
                    "",
                    "My father makes counterfeit money.\nMy mother brews synthetic gin.\nMy sister sells kisses to sailors.\nMy God how the money rolls in.\n||: Rolls in, rolls in, my God how the money rolls in, rolls in :||\n\nMy aunt keeps a girls seminary.\nShe's teaching young girls to begin.\nShe doesn't say when they shall finish.\nMy God how the money rolls in.\n||: Rolls in... :||\n\nMy brother's a slum missionary.\nHe's saving young girls from the sin.\nHe'll save you a blond for a shilling.\nMy God how the money rolls in.\n||: Rolls in... :||\n\nMy uncle's a Harley Street surgeon.\nWith instruments long, sharp and thin.\nHe only knows one operation.\nMy God how the money rolls in.\n||: Rolls in... :||\n\nI've spent all the counterfeit money,\nI've drunk all the synthetic gin,\nI've been making love to my sister.\nMy God, what a mess I am in!\n||: I'm in, I'm in, my God what a mess I am in, I'm in :||",
                    ""));
            songs.Add(new Song(
                    "Spritbolaget",
                    "Melodi: Snickerboa",
                    "",
                    "Till spritbolaget ränner jag\noch bankar på dess port.\nJag vill ha nåt som bränner bra\noch gör mig skitfull fort.\nExpediten sade goddag,\nhur gammal kan min herre va?\nHar du nåt leg, ditt fula drägg,\nkom hit igen när du fått skägg.\n\nMen detta var ju inte bra,\njag vill bli full i kväll.\nDå plötsligt en idé fick jag,\nde har ju sprit på Shell.\nFlaskorna de stod där på rad,\nså nu kan jag bli full och glad.\nDen röda drycken rinner ner...\n\nDrycken intages.\n\n...nu kan jag inte se nåt mer.",
                    ""));
            songs.Add(new Song(
                    "Uti min mage",
                    "Melodi: Uti vår hage",
                    "",
                    "Uti min mage en längtan mig tär,\nkom hjärtans fröjd.\nDär råder en hunger som ropar så här:\nkom kryddsill och kall potatis,\nkom brännvin och quantum satis,\nkom allt som kan drickas,\nkom hjärtans fröjd.\n\nUti min mage där växa begär,\nkom hjärtans kär.\nVill du mig något så har jag det där.\nKom Renat och Aqua Vitae,\nkom OP och allt vad sprit e',\nkom ljuva Genever,\nkom Överste.\n\nUti mitt hjärta en längtan mig tär,\nkom hjärtans fröjd.\nDär råder en hunger som ropar så här:\nkom famnande lena armar,\nkom läppar och sköna barmar,\nkom fagraste kvinnor,\nkom hjärtans fröjd.",
                    ""));
            songs.Add(new Song(
                    "Jag var full en gång",
                    "Melodi: Flottarkärlek",
                    "",
                    "Jag var full en gång för länge sen,\npå knäna kröp jag hem.\nVarje dike var för mig ett vilohem.\nI varje hörn och varje vrå\nhade jag en liten vän,\nifrån renat upp till 96 procent, hemmabränt.\n\nJag var full en gång för länge sen,\npå knäna kröp jag hem,\noch i sällskap hade jag en elefant.\nElefanten spruta' vatten,\nmen jag trodde det var vin,\nsedan dess har alla kallat mig för svin, mera vin!\n\nJag var full en gång för länge sen\npå knäna kröp jag hem,\noch i sällskap hade jag en elefant.\nElefanten spruta' vatten,\nmen jag trodde det var öl,\nsedan dess har alla kallat mig för knöl, mera öl!\n\nJag var full en gång för länge sen,\npå knäna kröp jag hem,\noch i sällskap hade jag en elefant.\nElefanten spruta' vatten,\nmen jag trodde det var sprit\nsedan dess har alla kallat mig för skit, mera sprit!",
                    ""));
            songs.Add(new Song(
                    "Bamsesången",
                    "Melodi: Signaturmelodin till Bamse",
                    "Text: D-LTH, Sångarstriden 1987",
                    "Jag skall festa, ta det lugnt med spriten.\nHa det roligt utan att va' full.\nInte krypa runt med festeliten,\nta det varligt för min egen skull.\n\nFörst en öl i torra strupen,\nefter det så kommer supen,\ni med vinet, ner med punschen,\nsist en groggbuffé.\n\nJag är skitfull, däckar först av alla,\nmissar festen men vad gör väl de'.\nBlandar hejdlöst öl och gammal filmjölk,\nkastar upp på bordsdamen bredve'.\n\nFörst en öl...",
                    ""));
            songs.Add(new Song(
                    "Det var länge sen",
                    "Melodi: Det var länge sen jag plocka' några blommor",
                    "",
                    "Det var länge sen jag plocka' några tentor.\nDet var länge sen jag tog några poäng.\nDet var länge sen jag handla' på Systemet.\nDet var länge sen jag fick en grabb i säng.\nMen å andra sidan bränner jag ju hemma,\noch klarar kärleken alldeles för mig själv.\nDet var länge sen jag plocka' några tentor,\nmen å andra sidan går de om igen.",
                    ""));
            songs.Add(new Song(
                    "Dance macabre",
                    "Melodi: Vårvindar friska",
                    "",
                    "Runt kring vår stuga, smådjävlar sluga\ndansa så tyst med bockfot och svans.\nVarulvar yla, isande kyla\nsveper i dimman fanstygens dans.\nBäva o broder, lyssna och hör\nvrålen från gast, som osalig dör.\nSatan han skrattar, flaskan han fattar,\nsuper tills dagen gryr.\n\nGastar och spöken, skymtar i kröken,\ndödingar släpa ruttnande lik.\nBenrangel skramla, spökhänder famla,\nkväva din strupes rosslande skrik.\nHelvetes alla fasor släpps loss.\nFan rider här med hela sin tross.\nGöm dig i stugan, du har fått flugan.\nDille det blir din lott.\n",
                    ""));
            songs.Add(new Song(
                    "Var rädd om din fyrfota vän",
                    "",
                    "",
                    "Var rädd om din fyrfota vän,\nför en anka kan vara dess mamma.\nSom simmar omkring i en damm\njust när solen tittar fram,\noch nu tror du att visan är slut\noch det är den!\n(Inte!)",
                    "Kan upprepas nästan hur många gånger som helst..."));
            songs.Add(new Song(
                    "Nu vill jag supa",
                    "",
                    "",
                    "||: Nu vill jag supa nu me'ns jag lever,\nnär jag är död så kan jag inte mer. :||\nNär jag väl en gång ligger i mull,\nkan jag väl inte supa mig full.\nNär jag väl en gång ligger i mull,\nkan jag väl inte supa.\n\n||: Nu vill jag gänga nu me'ns jag lever\nnär jag är död så kan jag inte mer. :||\nNär jag väl en gång ligger i mull,\nkan jag väl inte få mig ett knull.\nNär jag väl en gång ligger i mull\nkan jag väl inte gänga.\n\nDamernas vers:\n||: Nu vill jag suga nu me'ns jag lever,\nnär jag är död så kan jag inte mer. :||\nNär jag väl en gång ligger i mull,\nkan jag väl inte suga munnen full.\nNär jag väl en gång ligger i mull,\nkan jag väl inte suga.\n\nHerrarnas vers:\n||: Nu vill jag slicka nu me'ns jag lever,\nnär jag är död så kan jag inte mer. :||\nNär jag väl en gång ligger i mull,\nkan jag väl inte lapa munnen full.\nNär jag väl en gång ligger i mull,\nkan jag väl inte slicka.\n\n||: Nu vill jag kramas nu me'ns jag lever,\nnär jag är död så kan jag inte mer. :||\nNär jag väl en gång ligger i mull,\nkan jag väl inte få famnen full.\nNär jag väl en gång ligger i mull,\nkan jag väl inte gosa.",
                    "Under köns respektive verser är det andra könet tyst. De som också/istället föredrar det egna kön et sjunger även/istället under det andra könets vers"));
            songs.Add(new Song(
                    "Född i Norge",
                    "Melodi: Oh my darling Clementine",
                    "",
                    "Född i Norge, bor i Sverige,\nDanmark är mitt fosterland,\ntalar spanska som en jude,\nför jag är en engelsman.\n\nFull idag och full imorgon,\nså ser livet ut för mig.\nJag ska aldrig svika flaskan,\njag skall aldrig gifta mig.\n\nOch på min gravsten, på min gravsten,\nska det ristas på latin\natt i kistan vilar stoftet\nav ett jävla fyllesvin\n\nOch alla maskar, alla maskar\nde skall krypa i min kropp.\nOch de ska bli så djävla fulla\natt de aldrig hittar opp.",
                    ""));
            songs.Add(new Song(
                    "De som är nyktra",
                    "Melodi: Du är den ende",
                    "",
                    "De som är nyktra\nde har inget roligt,\nde har bara ansvar\noch inte nå't tjolitt-\nanlej faderulla.\nMen vi som är fulla\nvi har bara kul, nästan jämt.\n\nDet sägs att en mänska\nkan va utan brännvin\ndet stämmer måhända\nmen se blott på den min\nsom pryder en absolutist\nden är jävligt trist\ndärför så sjunger vi så,\nliksom så:\n\nDe som är nyktra...",
                    ""));
            songs.Add(new Song(
                    "Eno",
                    "Melodi: Staffan stalledräng",
                    "",
                    "Eno är en masochist,\nvi slår honom så gärna.\nMotorsåg och giftig kvist,\nallt för den sjuka hjärna.\nInga skador synes än,\nspikarna i huvudet de blänka",
                    ""));
            songs.Add(new Song(
                    "Siffervisan",
                    "Melodi: Ritsch, ratsch, fillibom",
                    "",
                    "||: 1, 2, 75, 6, 7, 75, 6, 7, 75, 6, 7,\n1, 2, 75, 6, 7, 75, 6, 7, 73,\n107, 103, 102, 107, 6, 19, 27,\n17, 18, 16, 15, 13, 19, 14, 17,\n19, 16, 15, 11, 8, 47. :||",
                    "Upprepas allt snabbare tills alla gett upp."));
            songs.Add(new Song(
                    "Pelle Jöns",
                    "Melodi: Moster Ingeborg",
                    "Text: Britt G. Hallqvist",
                    "Det var en gång en daggmask som hette Pelle Jöns.\nHan var så rädd för skator, han var så rädd för höns.\nHan var så rädd för metare och letare med burk.\n'Den som tar mask på kroken, den kallar jag en skurk!'\n\nSå sa den lilla masken och borrade sig ner,\nen meter under jorden och syntes inte mer.\nI trädgården går metare och letare och höns.\nDe hittar många maskar, men ingen Pelle Jöns.",
                    ""));
            songs.Add(new Song(
                    "Moralvisa",
                    "Melodi: Vem kan segla",
                    "",
                    "Den som dricker mer än han tål,\nstrax runt badrummet crawlar,\ni sitt surplus av får i kål,\nbland roll-onnar och tvålar.",
                    ""));
            songs.Add(new Song(
                    "Kalmarevisan",
                    "",
                    "",
                    "Uti Kalmare stad\nja, där finns det ingen kvast\nförrän lördagen.\nHej dick\nHej dack,\njag slog i\noch vi drack,\nHej dickom dickom dack,\nhej dickom dickom dack.\nFör uti Kalmare stad,\nja, där finns det ingen kvast\nförrän lördagen.\n\n||: När som bonden kommer hem\nkommer bondekvinnan ut :||\när så stor i sin trut.\nHej...\n\n||: Var är pengarna du fått?\nJo, dom har jag supit opp :||\nuppå Kalmare slott.\nHej...\n\n||: Jag ska mäla dej an\nför vår kronbefallningsman :||\noch du ska få skam.\nHej...\n\n||: Kronbefallningsmannen vår\nsatt på krogen igår :||\noch var full som ett får.\nHej...",
                    ""));
            songs.Add(new Song(
                    "Drunken sailor",
                    "",
                    "",
                    "What shall we do with the drunken sailor,\nwhat shall we do with the drunken sailor,\nwhat shall we do with the drunken sailor,\nearly in the morning?\nHooray, up she rises,\nhooray, up she rises,\nhooray, up she rises,\nearly in the morning.\n\nPut him in the longboat till he's sober...\n\nPull out the plug and wet him all over...\n\nPut him in the bilge and make him drink it...\n\nPut him in a leaky boat and make him bale it...\n\nPut him in the scrubbers with the hosepipe on him...\n\nShave his legs with a rusty razor...\n\nKeel haul him until he's sober...\n\nPut him in a bed with the captains daughter...\n\nThat's what we'll do with the drunken sailor...",
                    ""));
            songs.Add(new Song(
                    "Balladen om den onyktre",
                    "Melodi: När månen vandrar på fästet blå",
                    "",
                    "När jag är fuller då är jag glad,\nfan vet om jag ej är vacker.\nJag vandrar kring i vår lilla stad,\nibland lyxhus och baracker.\nJag sjunger ljuvligt en serenad,\ndet gör jag bara när jag är glad\noch full och vacker, och full och vacker.\n\nNär jag är fuller då är jag stark,\nfan vet om jag ej är modig.\nDå kan jag slå vem som helst i mark,\nså han blir trasig och blodig.\nJag välter träden i våran park,\ndet gör jag bara när jag är stark\noch full och modig, och full och modig.\n\nNär jag är fuller då är jag rik,\nfan vet om jag ej är snille.\nOch dör jag blir jag ett vackert lik,\nbegravs med gravöl och gille.\nI himlen möts jag av hornmusik,\ndet gör man bara när man är rik\noch är ett snille, och är ett snille.\n\nMen när jag vaknar upp nästa dag,\nuppå ett enkelrum med galler.\nDå känner jag mig så rysligt svag,\noch hatar bråk och kravaller.\nmin mage krånglar och är ur lag,\nnog fan så vet jag att jag idag\när bakom galler, är bakom galler.\n\nDamernas extravers: (Text: Emma Wibom)\n\nNär jag är fuller då är jag snygg,\nfan vet om jag ej är stilig.\nDå kan jag få vem som helst på rygg,\ndå kan jag få vemhelst villig!\nJa, alla gossarna får jag omkull,\ndet får jag bara när jag är full\noch snygg och stilig, och snygg och stilig.",
                    ""));
            songs.Add(new Song(
                    "Vi som oss för att glupa satt",
                    "Melodi: Vi gå över daggstänkta berg",
                    "",
                    "Vi som oss för att glupa satt, supa glatt,\nity den som försmå sin första tår, törsta får.\nAv längtan vi tryckas,\nav trängtan att lyckas,\nvi nu med bravur häller ur, eller hur?\n\nVi ge titt och tätt strupen sitt, supen stritt\nskall forsa och snart får tarmen vår, varm en tår.\nEr öven i seder\noch söven ned Eder.\nPå denna protestbullerfest, full är bäst.",
                    ""));
            songs.Add(new Song(
                    "Störthärligt full",
                    "Melodi: Fat Mammy Brown",
                    "",
                    "Nu har alla lämnat festen\noch jag sitter ensam kvar\nibland groggar, pilsnerflaskor\ni en sönderslagen bar.\nSista pilsnerflaskan tog jag\ntill min frukost klockan fem\noch nu sitter jag och väntar\npå att få bli buren hem.\n\nFör jag är störthärligt full\noch jag ramlar mest omkull.\nJag ser skära elefanter\nsom har jättekonstig ull.\nJa, jag är störthärligt full\noch jag ramlar mest omkull.\nDet är präktigt, härligt,\nsupa och va' full.\n\nIfrån festen minns jag inget,\nmen mitt öga blev visst blått.\nOch det måste jag ha fått\nnär någon kastat en karott\nfull med vispgrädde och fimpar\noch en okammad peruk,\neller också när jag stod\ni moraklockan och var sjuk.\n\nFör jag är...\n\nNästa morgon när jag vaknar\nmed en bergsborr i min kropp.\nSandpapper på tungan\noch jag vill ej stiga opp.\nMina armar dom känns tunga\noch min näsa den är sne'.\nSå jag raglar ut till köket\nför en återställare.\n\nFör jag är...",
                    ""));
            songs.Add(new Song(
                    "Lyft ditt välförsedda glas",
                    "Melodi: Ding Dong Merrily on High",
                    "",
                    "Lyft ditt välförsedda glas\ndet är en ljuvlig börda,\nnu har grabbarna kalas,\noch vi skall segern skörda!\nDing, dinge-dinge-ding\ndinge-dinge-ding\ndinge-dinge-ding, dong-dong,\ni morgon är det lördag.\n\nLyft nu glaset till din mun,\nse, döden på dig väntar!\nNu har grabbarna kalas,\nhör, liemannen flämtar!\nDing, dinge-dinge-ding\ndinge-dinge-ding\ndinge-dinge-ding, dong-dong.\nBegravningsklockor klämtar.",
                    ""));
            songs.Add(new Song(
                    "Sakta det går med banan",
                    "Melodi: Sakta vi gå genom stan",
                    "Text: Torbjörn H, Mats T, Peo K och Lennart H.",
                    "Å, det är skönt\natt med frukter och grönt\nuppnå ett djupare plan.\nJag vet ett sätt\ndå man inte blir mätt,\nmen ändå rätt nöjd med banan.\nDet finns dom som säger\natt endast vi tjejer\nkan uppskatta morotens form.\nMen grönsaker kan\nvara svåra ibland,\nta pumpan - den är ju enorm!\n\nJag har gjort försök\nmed kålrot och lök,\nmen det kliar och svider som fan.\nEn ärta, javisst,\nmen det blir rätt trist,\nnej, ingenting slår min banan!\n\nEn köttkorv är nog\nbåde nyttig och god,\nmen såsen gör magen så rund...\nNej, grönt ska det va',\ntänk, så skönt att få ha\nmed gurka en ljuv herdestund!\n\nJag har testat kiwi,\nmen den var för rivig,\nnej, ta av bananen dess skal!\nFör då har jag känt\natt dess friktionsko'ff'cient\nhar blivit för mig optima-al!\n\nBanan, vilken grej!\nBra för mig som är tjej!\nJag är ju ve-ge-tarian!\nMed skal eller ej,\njag vill ha den i mig.\nSakta det går med banan...\nSakta det går med banan...",
                    "Lantmäterisektionens bidrag i Sångartäflan 1987."));
            songs.Add(new Song(
                    "Nikolajevs längtan",
                    "Melodi: Ryska nationalsången",
                    "",
                    "Mitt namn är Nikolajev, kosmonaut ifrån Sovjet.\nJag åker runt jorden i min rymdraket,\nmen drabbats jag har av en olycka stor,\nför jag glömde gå på muggen innan jag for\n\nJag längtar hem, till mitt fosterland igen,\ntill mor och far uti Sovjetien,\nmen mest utav allt så längtar jag till\nen röd liten stuga med hjärta på dörr'n!\nJag längtar hem!",
                    "11-15 augusti 1962 flög Andrian Nikolajev 64 varv runt jorden i Vostok 3."));
            songs.Add(new Song(
                    "Sista dansen",
                    "",
                    "",
                    "Om han skulle dansa sista dansen med mig,\nsom jag tror att han gör,\nhan har gjort så en gång förr,\nså får han inte följa mig till porten i kväll.\nDet lovar jag dig,\ndet lovar jag min mamma och det lovar jag dig.\n\nMen om han skulle följa mig till porten i kväll...\nså får han inte följa mig på rummet i kväll...\n\nMen om han skulle följa mig på rummet i kväll...\nså får han inte sätta sig på sängen med mig...\n\nMen om han skulle sätta sig på sängen med mig...\nså får han inte krypa under fällen med mig...\n\nMen om han skulle krypa under fällen med mig...\nså får han inte röra kussimurran på mig...\n\nMen om han skulle röra kussimurran på mig...\nså får han inte ränna sturske Laban i mig...\n\nMen om han skulle stoppa sturske Laban i mig...\nså får han inte släppa stora satsen i mig...\n\nMen om han skulle släppa hela satsen i mig...\nså får han inte göra små små flickebarn med mig...\n\nMen om han skulle göra små små flickebarn med mig...\nså får det inte bli någon 25-örestjej...\n\nMen om det skulle bli någon 25-örestjej...\nså får hon inte kallas kåta Lisa efter mig...\n\nMen om hon skulle kallas kåta Lisa efter mig...\nså får hon inte stjäla några kunder av mig...\n\nMen om hon skulle stjäla några kunder av mig...\nså får hon inte dansa sista dansen med dig...",
                    ""));
            songs.Add(new Song(
                    "Somnarvisa",
                    "Melodi: Idas sommarvisa",
                    "",
                    "Du ska inte tro du får somna\nnär spriten har satt lite fart.\nOm armar och ben börjar domna\nså börjar vi dansa såklart!\nOch när jag har fångat dig i min famn\nså släpper jag inte mitt grepp.\nJag älskar dig, fast jag har glömt ditt namn\njag håller, fast du skriker 'Släpp!'",
                    ""));
            songs.Add(new Song(
                    "I ett hus vid skogens slut",
                    "",
                    "",
                    "I ett hus vid skogens slut,\nliten tomte tittar ut.\nHaren skuttar fram så fort,\nklappar på dess port.\nHjälp ack, hjälp ack, hjälp du mig,\nannars skjuter jägarn mig.\nKom, ja, kom i stugan in,\nräck mig handen din.",
                    ""));
            songs.Add(new Song(
                    "Katta vore",
                    "Melodi: Du ska få min gamla cykel när jag dör",
                    "",
                    "Katta vore hon ha onge unner lon, unner lon.\nKatta vore hon ha onge unner lon, unner lon.\nSnälla pappa ta en häschitro\nå peta fram kattonga,\nta å peta fram kattonga jer du bra, pappa du.\n\nPappa to en häschjestang å peta fram, allihop.\nPappa to en häschjestang å peta fram, allihop.\nEn var grön å svart å brokut\nå den ann va alldeles tokut,\ntredje ongen han va alldeles kall å slö\nför han va dö.\n\nPappa han ha hormoslyr å DDT, oppå lon.\nPappa han ha hormoslyr å DDT, oppå lon.\nHe had fyrä jörning golva\npå na konstit märklit vis,\nhe jer väl trolit he va därför eint dom vor\nsom dom skull",
                    "Ska sjungas på arvidsjaursbondska."));
            songs.Add(new Song(
                    "Min häst",
                    "",
                    "Text: Lasse Åberg",
                    "Min häst den har gula öron,\noch vita små skor av trä.\nRöda strumpor till knät,\nhan är ganska fet,\nmed blåa små vingar under magen.",
                    ""));
            songs.Add(new Song(
                    "Jag är en liten undulat",
                    "Melodi: Med en enkel tulipan",
                    "",
                    "Jag är en liten undulat\nsom får så dåligt med mat.\nFör dom jag bor hos, för dom jag bor hos\ndom är så snåla.\nDom äter sill, varenda da',\ndet vill jag rakt inte ha.\nJag vill ha brännvin, jag vill ha brännvin\nså jag får skåla.",
                    ""));
            songs.Add(new Song(
                    "A long time ago",
                    "Melodi: Schuberts Marche Militaire",
                    "",
                    "A long time ago in a small town in Germany\nthere was a shoemaker, Shoemaker was his name.\nHe could play the violin, violin, violin\nhe could play the violin, vio-violin.\n\nA long time ago...\nHe could play the trombone...\n\nA long time ago...\nHe could play the piccolo...\n\nA long time ago...\nHe could play the el-guitar...\n\nA long time ago...\nHe could play the bloody fool...",
                    ""));
            songs.Add(new Song(
                    "Lille Olle",
                    "Melodi: Katjuscha",
                    "Text: Calle Isaksson",
                    "Lille Olle skulle gå på disco,\nmen han hade inte någon sprit.\nLille Olle skaffa' lite hembränt,\nlille Olle gick då på en nit.\n\nLa lalla la la la...\n\nLille Olle skulle börja festa,\nspriten blandade han ut med Mer.\nLille Olle drack upp hela bålen,\nlille Olle ser nu inte mer.\n\nLa lalla la la la...\n\nLille Olle skaffade en ledhund,\nden var ful, men även ganska trind.\nOlles ledhund drack upp femton flaskor,\nOlles ledhund är nu också blind.\n\nLa lalla la la la...\n\nLille Olle började med droger,\nblandade sin LSD med juice.\nLille Olles hjärna står i lågor,\nlille Olle dog av överdos.\n\nLa lalla la la la...\n\nLille Olle sitter nu i himlen,\nfesta kan man även göra där.\nLille Olle skaffade en ölback,\ncapsar nu med Gud och Sankte Per.\n\nLa lalla la la la...",
                    "Skrevs 1991 då textförfattaren gick D-linjen på LiTH."));
            songs.Add(new Song(
                    "Det var i vår ungdoms fagraste vår",
                    "",
                    "",
                    "Det där det gjorde han/hon/de fan så bra,\nen skål uti botten för honom/henne/de (nu) vi ta.\nHugg i och dra - hej!\nHugg i och dra - hej!\nEn skål uti botten för honom/henne/dem (nu) vi ta.\nAlla så dricka vi nu NN till,\noch NN han säger inte nej därtill.\nDet var i vår ungdoms fagraste vår,\nvi drack varandra till, och vi sade gutår!",
                    "Sjunges som tack för något berömvärt."));
            songs.Add(new Song(
                    "Raj, raj",
                    "Melodi: Elvira Madigan",
                    "",
                    "Om vi inga texter kunna\nsjunga vi blott dessa ord:\nRaj, raj, raj, raj, raj, raj, raj, raj,\nraj, raj, raj, raj kring vårt bord",
                    ""));
            songs.Add(new Song(
                    "Lingonben",
                    "Melodi: Povel Ramel",
                    "Text: Povel Ramel",
                    "Bluff och Spark och Tork och Kvark\nvoro sex små dvärgar.\nEn var ful och en var glad\noch en var dum i huv'et.\nHej, sa' Kvark till lille Tork,\nkänner du igelkotten Pilt?\nHan som har varit i Paris?\nJa, det gjorde Ivar.\nHör du hans lilla runda tass\nnär som han trippar på sitt pass;\nTripp och trapp och trypa,\nse hans lilla faster.\n\nTomtefar i skogens brus\nsitter som ett päron.\nHan har inget eget hus\nallt i sin stora näsa.\nSöt och blöt är skogens fé,\ntrollen är bjudna hit på te.\nDet lilla trollet! Pass för de'!\nNu skall mormor bada!\nVäva och spinna natten lång,\nprinsen är här i fjorton språng!\nHopp och hipp och häppla.\nHästen heter Sverker.\n\nStora slottet Drummeldimp\nligger bortom fjärran.\nDit får ingen komma in\nsom ej kan baka struvor.\nGyllenkrull och Sockertipp,\nkom, ska vi dansa häxan våt.\nVill du mig här, så har du nå't.\n Sov du lilla tryne.\nKungen är full av stock och sten.\nSkogen är full av lingonben.\nPer är full av tomtar,\nhur skall Lillan orka?",
                    "Även känd under titeln 'Nonsensvisa'."));
            songs.Add(new Song(
                    "Hoppe Hoppe Hare",
                    "Melodi: Imse vimse spindel",
                    "",
                    "Hoppe Hoppe Hare satt och mumsa bär\nklappa sig på magen, 'det va' gott de' här'.\nFram smyger räven, tänker Hoppe ta,\nmen Hoppe Hoppe Hare hoppar ju så bra.\n\nHoppe Hoppe Hare hoppa' in i sten\nstuka lilla tassen, bröt sitt långa ben.\nFram smyger räven, knäcker Hoppes hals.\nHoppe Hoppe Hare hoppar inte alls.",
                    "Vid 'bröt' och 'knäcker' kan man t.ex. bryta sönder plastbesticken."));
            songs.Add(new Song(
                    "Solen",
                    "Melodi: Camptown Races",
                    "",
                    "Solen den går upp och ner, doda doda.\nJag skall aldrig supa mer, hej doda dej.\nHej doda dej, hej doda dej.\nJag skall aldrig supa mer, hej doda dej.\n\nMen detta det var inte sant, doda doda.\nI morgon gör jag likadant, hej doda dej.\nHej doda dej, hej doda dej.\nI morgon gör jag likadant, hej doda dej.",
                    ""));
            songs.Add(new Song(
                    "En kulen natt",
                    "",
                    "",
                    "En kulen natt-natt-natt, \nmin båt jag styrde\npå havets vågade-vågade-våg,\n så skummet yrde.\nOch vart jag sågade-sågade-såg\npå havets vågade-vågade-våg\nlångt ner i djupete-pete-pete-pet\nen fisk jag såg och det var du!",
                    ""));
            songs.Add(new Song(
                    "Tårtan",
                    "",
                    "",
                    "Socker, grädde, nötter och mandelflarn.\nOch så sist, men inte minst:\nen liten ros av marsipan.\nSmörkräm, krikon, snabbkräm och gott gelé.\nFrasses deg och en flaska saft\noch så en liten klick med sylt.",
                    ""));
            songs.Add(new Song(
                    "Älsk me gullong",
                    "Melodi: Love me tender",
                    "",
                    "Älsk mä Gullong, hall mä hart,\nkrama heile mäg.\nBloon män fa sån himla fart\nse fort i sej på däg.\nÄlsk mä Gullong, kan eint vänt,\nkänn se varm i jer.\nI jer eint skakkerhent,\ni jer bara kär.\n\nÄlsk mä Gullong, älsk mä fort,\ndu hav hjärte mett.\nLive jer ju alltför kort,\ndjiv mä hjärte dett.\nÄlsk mä Gullong, kom-kom-kom\nlett natta vahl deill dag.\nOrk vä eint da böri vä om,\nsä vihl vä oss ett tag.\n\nÄlsk mä Gullong, älsk mä nöuv,\ntro du att i löög.\nHe feinns eingen ann än döuv,\ni älsk dä deill i döö.\nÄlsk mä, snart jer he för saint,\ntjänn vå i vibrer.\nI jer eint skakkerbaint,\ni jer bara kär.",
                    ""));
            songs.Add(new Song(
                    "Skånsk madavisa",
                    "Melodi: Aspelöv och lindelöv",
                    "",
                    "Rabbemos å spegefläsk, panntofflagröd med knudor,\nfläskasvålar, grisatassar, prinsakorv me snudor,\nfittemadar, sillarumpor, sylta me röbedor,\näggakaga, revbensspjäll.\n\nLuad ål, å rögad ål, å ål som di har halmad,\nkogad ål, å stegad ål, å ål i gelantin,\nålasluring, ålapudding, ål me chokelasås,\nrutten ål, å ål i kål.\n\nHussegröd å puggavälling, kläggefläsk me bläror,\ntösaflabbar, flinerumpor, pattagris me päror,\nglyttanäsor, hunnarövar, lommemög me hylle,\nmormor Karnas hönsafjäs.\n\nSillasupen, ålasupen, supen till sardellen,\nfläskasupen, rabbesupen, suparna till spjällen,\ngåsasupen, äggasupen, suparna till supen,\nå till sist en kagesup.\n\nSpiddekaga, kransakaga, flarn å mazariner,\nsockerkaga, butterkaga, nötter och praliner,\nrisengröd me vispegrädde, punsch å karameller.\nSen e de dags för nattamad!!!\n\nSkål!",
                    ""));

            songs.Add(new Song(
                    "Helan går",
                    "",
                    "",
                    "Helan går,\nsjung hopp, faderallanlallanlej.\nHelan går,\nsjung hopp, faderallanlej.\nOch den som inte helan tar\nhan heller inte halvan får\nHelan går!\nSjung hopp, faderallanlej!",
                    ""));
            songs.Add(new Song(
                    "Hell and Gore",
                    "Melodi: Helan går",
                    "",
                    "Hell and Gore,\nchung hop father Allan-Allan-ley.\nHell and Gore,\nchung hop father Allan-ley.\nOh, handsome in the hell and tar\nand hell are in the half and four.\nHell and Gore,\nchung hop father Allan-ley.\n",
                    ""));
            songs.Add(new Song(
                    "Alla tallarna",
                    "",
                    "Text: Lars T. Johansson och Ehrling Eliasson",
                    "Alla tallarna, alla tallarna, alla stora, alla små!\nAlla tallarna, alla tallarna, ska vi koka 'rännvin på!\nAlla tallarna, alla tallarna, ifrån roten till dess topp,\nAlla tallarna, alla tallarna, ska vi ta och 'ricka opp!\nSkål!",
                    ""));
            songs.Add(new Song(
                    "Måsen",
                    "Melodi: När månen vandrar",
                    "",
                    "Det satt en mås på en klyvarbom\n och tom i krävan var kräket.\n Och tungan lådde vid skepparns gom\n där han satt uti bleket.\n Jag vill ha sill hördes måsen rope\n och skepparn svarte: jag vill ha OP\n om blott jag får, om blott jag får.\n \n Nu lyfter måsen från klyvarbom\n och vinden spelar i tågen.\n OP:n svalkat har skepparns gom,\n jag önskar blott att jag såg en.\n Så nöjd och lycklig den arme saten,\n han sätter storsegel den krabaten,\n till sjöss han far och halvan tar!\n \n Nu månen vandrar sin tysta ban\n och tittar in i kajutan.\n Då tänker jag att på ljusa da'n\n då kan jag klara mig utan.\n Då kan jag klara mig utan måne,\n men utan Renat och utan Skåne,\n det vete fan, det vete fan.\n \n Den mås som satt på en klyvarbom,\n den är nu död och begraven,\n och skepparn som drack en flaska rom,\n han har nu drunknat i haven.\n Så kan det gå om man fått för mycket,\n om man för brännvin har fattat tycke.\n Vi som har kvar, vi resten tar.",
                    ""));
            songs.Add(new Song(
                    "JASen",
                    "Melodi: När månen vandrar på fästet blå",
                    "",
                    "Och JASen styrde mot Västerbron,\n men styrsystemet var trasigt.\n Piloten utsköt sig med kanon\n för planet vingla' så knasigt.\n Han ville uppåt, han ville mer\n men planet svarte: 'Jag vill ju ner\n mot alla hjon, på Västerbron.'",
                    "Skriven av dadderiet vid Datasektionen, KTH, i samband med n0llningen 1993."));
            songs.Add(new Song(
                    "I Norrland",
                    "Melodi: I Apladalen i Värnamo",
                    "",
                    "I Norrland växer det tallar höga,\n att de är höga det båtar föga.\n För en gång faller de än' omkull,\n allt för den eviga törstens skull!",
                    ""));
            songs.Add(new Song(
                    "Mera brännvin",
                    "Melodi: Internationalen",
                    "",
                    "Nu är det dags att taga supen,\n den stärker varje svag fysik.\n Den rinner ner igenom strupen,\n river gott som en tolvtums spik.\n \n Den är vårt hopp mot gula faran,\n vår tröst vid varje bleklagd sorg.\n Den stärker oss mot mask i magen,\n starkare än Sveaborg.\n \n Mera brännvin i glasen,\n mera glas på vårt bord,\n mera bord på kalasen,\n mer kalas på vår jord.\n \n Mera jordar kring månen,\n mera månar kring mars,\n mera marscher till Skåne,\n mera Skåne gud bevars!",
                    ""));
            songs.Add(new Song(
                    "För brännvin är jädrans gott",
                    "Melodi: Här kommer Karl-Alfred Boy",
                    "",
                    "För brännvin är jädrans gott.\n Blir bättre ju mer man fått.\n Men går man i golvet\n så där framåt tolv-ett\n så slår man sig jävligt hårt.",
                    ""));
            songs.Add(new Song(
                    "Livet är härligt",
                    "Melodi: Röda kavalleriet",
                    "",
                    "Livet är härligt!\n Tavaritj, vårt liv är härligt!\n Vi alla våra små bekymmer glömmer\n när vi har fått en tår på tanden, skål!\n \n Ta dig en vodka!\n Tavaritj, en liten vodka!\n Glasen i botten vi tillsammans tömmer,\n det kommer mera efter hand. En skål!\n \n Fingret i halsen!\n Tavaritj, ett stick i halsen!\n Magen på golvet vi tillsammans tömmer\n det kommer mera efter handen - skål!",
                    "Från Chalmersspexet 'Katarina II' 1959. Ett tillägg från den finlandssvenska studentföreningen Spektrum:"));
            songs.Add(new Song(
                    "När jag kom hem från gärdet",
                    "Melodi: Gärdesvisan",
                    "",
                    "När jag kom hem från gärdet\n så tog jag mig en knorr,\n för kläderna var våta,\n men strupen den var torr.\n ||: Och jag tänkte liksom så,\n det är bäst att blöta på,\n för strupen torkar fortare än kläderna ändå! :||",
                    ""));
            songs.Add(new Song(
                    "Ingen har det så bra",
                    "Melodi: Kväsarevalsen",
                    "",
                    "För ingen har det så bra som jag,\n nej, ingen har det så bra som jag.\n Förutom bror min, så vitt jag vet,\n som ligger i sprit uppå Riksmuse't.",
                    ""));
            songs.Add(new Song(
                    "Rattataa",
                    "",
                    "",
                    "Att dricka brännvin är en sed\n som ingen har oss lärt.\n Från början vi ej kunde\n men det var blott temporärt.\n \n Vi lärde oss så småningom\n det var nog värt besvär't.\n Titilurenbom, tutidalenpang.\n Det var nog värt besvär't.\n \n Rattataa, så tar vi oss en tuting.\n Rattataa, med mycket brännvin i.\n Rattataa, ratatataa\n dricka brännvin gillar jag\n för jag blir så full och glad.",
                    ""));
            songs.Add(new Song(
                    "Magen brummar",
                    "Melodi: Broder Jakob",
                    "",
                    "Magen brummar, jag försummar\n hälla dit mera sprit.\n Nu så ska vi dricka,\n så att vi får hicka,\n mera sprit, akvavit.",
                    ""));
            songs.Add(new Song(
                    "Hej på er bröder alla",
                    "",
                    "",
                    "Hej på er bröder alla,\n nu ska vi supa till dess vi falla\n och brännvinslitern, den är för liten,\n den är för liten för oss alla.\n \n Å en gång när jag är döder\n och lagd mellan tvenne bröder,\n begrav mig, begrav mig,\n i en brännvinskällare på Söder.\n \n Å på min gravsten ska det stå ristat\n med tvenne små enkla rader:\n Här vilar det en fyllebror\n som alltid var så god och glader.\n Ja, här vilar det en fyllebror\n som alltid var så glad och goder.",
                    ""));
            songs.Add(new Song(
                    "Supvisa",
                    "Melodi: Elvira Madigan",
                    "",
                    "Vad kan menas då man säger\n livets glädje flyktig är?\n Jo, den jäkeln ångtryck äger,\n nubben som dig väntar här.\n \n Låt den därför inte vänta:\n var sekund en dunst går bort.\n Denna negativa ränta\n bör vi stoppa som ett skott.",
                    ""));
            songs.Add(new Song(
                    "Imbelupet",
                    "Melodi: Kors på Idas grav",
                    "",
                    "Imbelupet glaset står på bräcklig fot.\n Tomma pilsnerflaskor luta sig därmot.\n Men där nere, miserere,\n uti magens dunkla djup,\n sitter djävulen och väntar på en sup!\n \n ...uti magens mörka valv,\n sitter djävulen och väntar på en halv!\n \n ...uti magen härs och tvärs,\n sitter djävulen och väntar på en ters!\n \n ...uti magen tom och svart,\n sitter djävulen och väntar på en kvart!\n \n ...uti magens labyrint,\n sitter djävulen och väntar på en kvint!\n \n ...uti magens slingerväxt,\n sitter djävulen och väntar på en sext!\n \n ...uti magen halvuppknäppt,\n sitter djävulen och väntar på en sept!\n \n ...uti magen an och av,\n vankar själve fan och väser på oktav!\n \n ...sitter allas våran far,\n det är Fan och han vill ha det som är kvar!",
                    ""));
            songs.Add(new Song(
                    "Än en gång däran",
                    "Melodi: Evert Taube",
                    "Text: Evert Taube",
                    "Än en gång däran, bröder! Än en gång däran!\n Följom den urgamla seden!\n Intill sista man, bröder, intill sista man,\n trotsa vi hatet och vreden!\n Blankare vapen sågs aldrig i en här,\n än dessa glasen, kamrater: I gevär!\n Än en gång däran, bröder! Än en gång däran!\n Svenska hjärtans djup - här är din sup!\n \n Livet är så kort, bröder! Livet är så kort!\n Lek det ej bort, nej var redo!\n Kämpa mot allt torrt, bröder! Kämpa mot allt torrt!\n Tänk på de gamle som skredo\n fram utan tvekan i floder av champagne,\n styrkta från början av brännvin från vårt land!\n Kämpa mot allt torrt, bröder! Kämpa mot allt torrt!\n Svenska hjärtans djup - här är din sup!",
                    "Skrevs i början av 1930-talet."));
            songs.Add(new Song(
                    "Fordom gällde lagen",
                    "Melodi: Kors på Idas grav",
                    "Text: Bosse Österberg",
                    "Fordom gällde lagen: 'Den som spar, han har!'\n Mottot är för dagen: 'Lämna inget kvar!'\n Töm i botten fyllda måtten,\n ej som skotten, slatten spar.\n Annars utav potten Staten halvan tar!",
                    ""));
            songs.Add(new Song(
                    "Vikingen",
                    "Melodi: When Johnny comes marching home",
                    "",
                    "En viking älskar livets vann,\n hurra, hurra!\n Den hastigt i mitt svalg försvann,\n hurra, hurra!\n Till kalv, till oxe, till fisk, till fläsk,\n när kärringar bara dricker läsk.\n Ja, då vill alla vikingar ha en bäsk.\n \n När bäsken småningom är slut,\n tragik, tragik\n Då bäres varje viking ut\n som lik, sig lik.\n Och se'n, om vi vaknar, vi sjunger en bit,\n se'n korkar vi upp Skånes Aquavit.\n Skål för alla vikingar som kom hit!",
                    ""));
            songs.Add(new Song(
                    "En gång i måna'n",
                    "Melodi: Mors lille Olle",
                    "",
                    "En gång i måna'n är månen full,\n aldrig jag sett honom ramla omkull.\n Stum av beundran hur mycket han tål,\n höjer jag glaset och säger nu skål.\n \n Höjer nu glasen och dricker ur.\n Nu kära bröder, står halvan i tur.\n Nubben den giver oss ny energi,\n säkert den minskar vårt livs entropi.",
                    ""));
            songs.Add(new Song(
                    "Törsten rasar",
                    "Melodi: Längtan till landet",
                    "",
                    "Törsten rasar uti våra strupar.\n Tungan hänger torr och styv och stel.\n Men snart vankas stora långa supar\n var och en får sin beskärda del.\n Snapsen kommer, den vi vilja tömma,\n denna nektar likt Olympens saft.\n Kommer oss att våra sorger glömma\n snapsen skänker hälsa, liv och kraft.\n \n Fordom odlade man vindruvsranka,\n av vars frukt man gjorde ädelt vin.\n Nu man pressar saften ur en planka,\n doftande av äkta terpentin.\n Höj nu bägaren, o bröder och systrar,\n låt den svenska skogen rinna kall,\n ned i strupen, och om du är dyster:\n Låt oss dricka upp en liten tall!\n \n Helan tänder helig eld i själen\n halvan rosar livet som en sky.\n Tersen känns från hjässan ner i hälen\n kvarten gör en som en mänska ny.\n Låt oss skåla med varann go' vänner,\n skål för våran levnads glada hopp.\n Törstens eld på nytt i strupen bränner.\n Leva livet! Skål och botten opp!",
                    ""));
            songs.Add(new Song(
                    "Får jag lov?",
                    "Melodi: Räven raskar över isen",
                    "",
                    "Han: ||: Första snapsen heter göken :||\n Säg, får jag lov? Säg, får jag lov,\n att byta byxor med fröken?\n \n Hon: ||: Andra snapsen den var värre :||\n Säg, får jag lov? Säg, får jag lov, \n att byta byxor med min herre?\n \n Han: Mina byxor är himmelsblå, \n men med dina är det si och så.\n Alla: Säg, får vi lov?\n Säg, får vi lov,\n att byta byxor med göken?",
                    "'Byta byxor' är sannolikt en bisarr felhörning av 'dricka du-skål', vilket var nog så viktigt på den tiden då det begav sig."));
            songs.Add(new Song(
                    "En visa till septen",
                    "Melodi: Nu skall vi skörda linet idag",
                    "",
                    "Nuskaviklämmaseptengutår,\n sjungaentrudeluttomdetgår,\n tjosanmohammedsnartärdetvår,\n julaftonärenfredag.\n Klunkklunkklunkklunkklunkklunk,\n blandaochgeblandaochge,\n abrakadabraklunk,\n julaftonärenfredag.",
                    ""));
            songs.Add(new Song(
                    "Venngarn",
                    "Melodi: Kors på Idas grav",
                    "",
                    "Säg, vad vore livet utan alkohol?\n För ju mer man dricker, desto mer man tål.\n Venngarn väntar på oss alla,\n vi ska mötas där en dag,\n med försupna och förvridna anletsdrag.\n \n Varför sörja nu för det som komma skall?\n Lev för ruset när du salig är och knall!\n Tids nog börjar ögat vattnas,\n handen darra, kran blir blå,\n men det ska supas ur ändå, spill på, spill på!",
                    ""));
            songs.Add(new Song(
                    "Denna thaft",
                    "Melodi: Helan går",
                    "",
                    "Denna thaft, den bästa thaft thythtemet haft.\n Denna thaft är den bätha thaft dom haft.\n Och den thom inte har nån kraft\n han dricka thkall av denna thaft.\n denna thaft, till landth, till thjöth, till havth!",
                    ""));
            songs.Add(new Song(
                    "Amanda",
                    "Melodi: I Apladalen i Värnamo",
                    "",
                    "Amanda gångar sig ner i lunden,\n där får hon se att en ko står bunden.\n Amanda gångar sig hem igen,\n slår upp en nubbe och sveper den.",
                    ""));
            songs.Add(new Song(
                    "Fillibrännvinbom",
                    "Melodi: Ritsch, ratsch, fillibom",
                    "",
                    "Brännvin fillibom-bom-bom\n är en härlig dryck för en törstig gom.\n Brännvin fillibom-bom-bom\n är mitt livs potatis-jom.\n Ett litet barn vid flaskan redan blivit van.\n Det sitter i, till dess vi gamla bli.\n Så följ de gamla lagarna,\n drick något starkt om dagarna,\n för det är bra för magarna\n och stärker vår aptit.\n ",
                    ""));
            songs.Add(new Song(
                    "Mitt lilla lån",
                    "Melodi: Hej, tomtegubbar",
                    "",
                    "||: Mitt lilla lån det räcker inte\n det går till öl och till brännvin. :||\n Till öl och brännvin går det åt,\n och till små flickor emellanåt.\n Mitt lilla...",
                    ""));
            songs.Add(new Song(
                    "Till supen tager man sill",
                    "Melodi: Vi gå över daggstänkta berg",
                    "",
                    "Till supen så tager man sill, fallera,\n men också ansjovis, om man vill, fallera.\n ||: Och om man är oviss, om sillen är ansjovis,\n så tar man bara några supar till, fallera. :||",
                    ""));
            songs.Add(new Song(
                    "Vodka, vodka",
                    "Melodi: Stenka Razin",
                    "",
                    "Vodka, vodka vill jag dricka,\n jag vill äta kaviar.\n ||: Jag vill älska russkij flicka.\n Jag vill spy i samovar. :||\n \n Uppi taket går en gädda\n med långa ludna svarta ben.\n ||: Men ni ska inte vara rädda,\n tag en sup och allt går väl! :||\n \n Vita möss som går i taket\n råma hest och trilla ned.\n ||: Men ni ska inte vara rädda,\n tag en sup och allt går väl! :||\n ",
                    ""));
            songs.Add(new Song(
                    "Humlorna",
                    "Melodi: Här kommer Karl-Alfred Boy",
                    "",
                    "||: Vi äro små humlor vi, bzz-bzz, :||\n vi äro små humlor som tar oss en geting.\n Vi äro små humlor vi, bzz-bzz!\n \n ||: Vi äro små fiskar vi, blubb-blubb, :|| \n vi äro små fiskar som tar oss en kallsup.\n Vi äro små fiskar vi, blubb-blubb!\n \n ||: Vi äro små änglar vi, flax-flax, :|| \n vi äro små änglar som tar oss en djävel.\n Vi äro små änglar vi, flax-flax!",
                    ""));
            songs.Add(new Song(
                    "Om cykling med mera",
                    "Melodi: Väva vadmal",
                    "Text: Povel Ramel",
                    "Man cyklar för lite',\n man röker för mycke'\n och man är fasen så liberal\n när det det gäller maten och spriten.\n Jag borde slutat för länge sen \n men denna sup är så liten.\n Vad tjänar att hyckla?\n Tids nog får man cykla.\n (En tredjedel drickes ur.)\n \n Man badar för lite',\n man röker för mycke'\n och man är...\n Det kan inte skada.\n Tids nog får man bada.\n (Nästa tredjedel drickes ur.)\n \n Man sover för lite',\n man röker för mycke'\n och man är...\n Njut var gudagåva!\n Tids nog får man sova.\n (Sista tredjedelen drickes ur.)\n Ja, det vill jag lova!",
                    ""));
            songs.Add(new Song("Cykelhandlarens visa", "", "", "Åh, hoj!", ""));
            songs.Add(new Song(
                    "Tjugotre",
                    "Melodi: Amanda Lundbom",
                    "",
                    "Tjugotre är Beska Droppar,\n bomfaderi, bomfaderaderalla.\n Skänker liv åt döda kroppar,\n bomfaderi, faderallanlej.\n Slå en sup i död mans kropp,\n bomfaderi, faderallanlej. Hugg i!\n Så stapplar han ur graven opp,\n bomfaderi faderallanlej.\n \n Jesus visste att de döda,\n bomfaderi, bomfaderaderalla,\n Kunde väckas utan möda,\n bomfaderi faderallanlej.\n Beska Droppar nyttja' han,\n bomfaderi, faderallanlej. Hugg i!\n Och Lazarus spratt till, minsann,\n bomfaderi faderallanlej.\n ",
                    ""));
            songs.Add(new Song(
                    "Nu hoppar laxen",
                    "Melodi: I Apladalen i Värnamo",
                    "",
                    "Nu hoppar laxen, nu blommar häggen\n nu lyfter taxen sitt ben mot väggen.\n \n Ssssss...skål! (Supen tages.)\n \n Ett litet avbrott har visan fått,\n och under tiden har taxen gått.",
                    ""));
            songs.Add(new Song(
                    "Toj hemtegubbar",
                    "Melodi: Hej, tomtegubbar",
                    "",
                    "||: Toj hemtegubbar gla i slåsen,\n och loss tå vastiga lura! :||\n En tiden lid vi heva lär\n med möcket myda och svärt bestor.\n Toj hemtegubbar gla i slåsen,\n och loss tå vastiga lura!",
                    ""));
            songs.Add(new Song(
                    "Helan gick i vänstra foten",
                    "Melodi: Amanda Lundbom",
                    "",
                    "Helan gick i vänstra foten,\n bomfaderi, bomfaderaderalla.\n Gudskelov så vet vi boten,\n bomfaderi, faderallanlej.\n Halvan ställer saken rätt,\n bomfaderi, faderallanlej. Hugg i!\n På nubbar blir man aldrig mätt,\n bomfaderi faderallanlej.",
                    ""));
            songs.Add(new Song(
                    "Fans hämnd",
                    "Melodi: Där som sädesfälten",
                    "",
                    "När som sädesfälten böja sig för vinden...\n står nån djävul där och böjer dem tillbaks!",
                    ""));
            songs.Add(new Song("Sjömannens visa", "", "", "Åh, boj!", ""));
            songs.Add(new Song(
                    "O.P. river",
                    "Melodi: Ol' man river",
                    "",
                    "O.P. river\n ja, O.P. river\n var gång jag lenat\n min hals med Renat\n jag sagt med iver\n att O.P. river \n långt mer,\n långt mer.\n \n Mången glädes\n när han fått Sädes\n och fattighjonet \n ses le mot Kronet,\n men faktum bliver\n att O.P. river \n långt mer,\n långt mer.",
                    ""));
            songs.Add(new Song(
                    "Ekorr'n satt i tallen",
                    "Melodi: Ekorr'n satt i granen",
                    "",
                    "Ekorr'n satt i tallen,\n bryggde lite planksaft.\n Därav blev han knall, men\n överfylld av manskraft,\n hoppa han till stugan så,\n våldtog katten och gick på\n med den långa ludna svansen.",
                    ""));
            songs.Add(new Song(
                    "Den gamla apparaten",
                    "Melodi: Där som sädesfälten",
                    "",
                    "Där som sädesbrännvin rann igenom strupen,\n och en flaska dunder väntar bakom den.\n Stod den gamla apparaten uppå spisen,\n som i forna dagar var min bästa vän.\n Så kom länsman, tog det käraste jag ägde.\n Tog den gamla apparaten med sig hem.\n Nu står alla glasen tomma uppå bordet,\n och han bränner själv, den gamle djävulen.",
                    ""));
            songs.Add(new Song(
                    "Tänk om man hade",
                    "Melodi: Hej, tomtegubbar",
                    "",
                    "||: Tänk om man hade lilla nubben\n uppå ett snöre i halsen. :||\n Man kunde dra den upp och ner\n så att det kändes som många fler.\n Tänk om man hade lilla nubben\n uppå ett snöre i halsen.",
                    ""));
            songs.Add(new Song(
                    "Barndom",
                    "Melodi: I Apladalen i Värnamo",
                    "Text: Magnus Jönsson",
                    "När jag var liten i skolmatsalen,\n all djävla lever gjorde mig galen.\n Nu tar jag hämnd på detta organ...\n min egen lever ska få på fan.",
                    ""));
            songs.Add(new Song(
                    "För att människan",
                    "Melodi: Bä bä, vita lamm",
                    "",
                    "För att människan\n skall trivas på vår jord\n bör hon ständigt ha\n på sitt smörgårsbord:\n en stor, stor sup åt far,\n en liten snaps åt mor,\n och två små droppar\n åt lille, lille bror.",
                    ""));
            songs.Add(new Song(
                    "Då verka lätt",
                    "Melodi: Dover Calais",
                    "",
                    "När jag tar mig en sup\n blir jag intressant och djup.\n Allting som är svårt kan då verka lätt.\n All min rädsla går bort\n med en grogg av någon sort.\n Allting som är svårt kan då verka lätt!",
                    ""));
            songs.Add(new Song(
                    "Pärlan",
                    "Melodi: Mors lille Olle",
                    "",
                    "Sup kallas pärla, det kan man förstå,\n öppnar ju skalet hos män'skan också.\n I glaset den lovande, glittrande bor,\n som musslan i botten den tas nu, min bror.",
                    ""));
            songs.Add(new Song(
                    "'rännvinskokaren",
                    "Melodi: En sockerbagare här bor i staden",
                    "Text: Lars T. Johansson, Ehrling Eliasson",
                    "En 'rännvinskokare\n här bor i skogen.\n Han säljer 'rännvinet\n svart till krogen.\n Å ä' du nykter \n så kan du gå.\n Men ä' du fuller\n så kan du int'.",
                    ""));
            songs.Add(new Song(
                    "Vi går över ån",
                    "Melodi: Vi gå över daggstänkta berg",
                    "",
                    "Vi går över ån efter sprit, fallera,\n men efter vatten går vi ej en bit, fallera,\n ja, sup kära bröder\n fast näsan är röder\n för tids nog blir den akvavit, faller av!",
                    ""));
            songs.Add(new Song(
                    "Dalarna",
                    "Melodi: I Apladalen i Värnamo",
                    "Text: Magnus Jönsson",
                    "En sträng, ny präst i en by i Dalom,\n han sa att sprit blir det inte tal om.\n Istället tar vi, det tycker jag,\n en redig nattvard varenda dag.",
                    ""));
            songs.Add(new Song(
                    "Vem sade ordet skål?",
                    "Melodi: Vårvindar friska",
                    "",
                    "Vem sade ordet skål här vid bordet,\n viskande for det sällskapet kring.\n Fattom kristallen, nubben är kall den,\n stiger åt skallen, kling klingeling!\n Käraste vänner, välkomna hit,\n hoppas ni har en 'bon appetit'.\n Nu lilla nubben, tager vi stubben\n Skål lilla nubben, kling klingeling.",
                    ""));
            songs.Add(new Song(
                    "I Frankrike dricks det viner",
                    "Melodi: Te Deum (Eurovisions-signaturen)",
                    "",
                    "I Frankrike dricks det viner,\n när tyskarna dricker öl\n underbart de mår.\n Men svenskar som dricker, svin är.\n Oss svin emellan:\n tag en tår!",
                    "Ur Chalmersspexet 'Dr Livingstone' 1978."));
            songs.Add(new Song(
                    "Vad säger svenska folket",
                    "Melodi: Kungliga Södermanlands regementes paradmarsch",
                    "",
                    "Vad säger svenska folket\n när dom får en sup?\n Jo, jag tackar!",
                    ""));
            songs.Add(new Song(
                    "Jag tror, jag tror",
                    "Melodi: Jag tror, jag tror på sommaren",
                    "",
                    "Jag tror, jag tror på akvavit,\n jag tror, jag tror på dynamit,\n den ger en kraft att sjunga ut\n och ingen krämpa blir akut.\n Man glömmer vardagslivets jäkt\n och känner stundens ruseffekt.\n En snaps, en skål, en truddelutt\n och sen så tar vi våran hutt.",
                    ""));
            songs.Add(new Song(
                    "Nu har vi ljus",
                    "Melodi: Julpolska",
                    "",
                    "Nu har vi ljus här i vårt hus.\n Far han har tagit sig ett kraftigt rus.\n Mor hon är full, dansar omkull, välter ett ljus. Hej!\n Se hur alla barnen brinner inne.\n Fjorton stycken, lille Karl i minne.\n Farfar trogen, han säljer plogen\n och går åt skogen på krogen.",
                    ""));
            songs.Add(new Song(
                    "Tussan lull",
                    "Melodi: Byssan lull",
                    "",
                    "||: Tussan lull, utav brännvin blir man full,\n och slipsen man doppar i smöret. :||\n Och näsan den blir röd,\n och ögonen får glöd,\n men tusan så bra blir humöret.",
                    ""));
            songs.Add(new Song(
                    "När helan man tagit",
                    "Melodi: Skånska slott och herresäten",
                    "",
                    "När helan man tagit och halvan skall dricka(s),\n det är som att kyssa en nymornad flicka(s).\n Ju mera man får desto mer vill man ha(s).\n En ensammer jäkel gör alls ingen gla'(s)!\n Skål!",
                    ""));
            songs.Add(new Song(
                    "En liten fyllhund",
                    "Melodi: Mors lille Olle",
                    "",
                    "En liten fyllhund på krogen satt,\n rosor på kinden men blicken var matt,\n Läpparna små, liksom näsan var blå.\n Ack, om jag kunde så skulle jag gå!",
                    ""));
            songs.Add(new Song(
                    "Det var en tvilling",
                    "Melodi: Petter Jönssons resa till Amerika",
                    "",
                    "Det var en tvilling av det siamesiska slaget\n som ej tog färre än tvenne supar i taget.\n Han Helan tog för att därmed hedra sin moder,\n med Halvan reta' han sin helnyktre broder.",
                    ""));
            songs.Add(new Song("Vad blåser det för vind idag?", "", "",
                    "Vad blåser det för vind idag?\n \n - Brännvind!", ""));
            songs.Add(new Song(
                    "Magen skriker",
                    "Melodi: Kors på Idas grav",
                    "",
                    "Magen skriker, strupen brinner efter mer.\n Därför tar vi tersen, sen så tar vi fler.\n Ingen olja kan som brännvin få maskinen i funktion.\n Brännvin gör ett fylleskrål till ädel ton.",
                    ""));
            songs.Add(new Song(
                    "Brännvin hit",
                    "Melodi: Skära havre",
                    "",
                    "Brännvin hit och brännvin dit,\n och brännvin är det bästa.\n Och fan ta den som brännvin har\n och inte bju'r sin nästa.",
                    ""));
            songs.Add(new Song(
                    "Invers aptit",
                    "Melodi: Nu tändas tusen juleljus",
                    "",
                    "Nu fyllas många magar små\n av iskall renad sprit.\n Men några kastar åter opp.\n Det är invers aptit.",
                    ""));
            songs.Add(new Song(
                    "Ner med supen",
                    "Melodi: Broder Jakob",
                    "",
                    "Ner med supen, genom strupen,\n drick blott till, om du vill.\n Spotta ej i glaset, säger fylleaset,\n ta en till, om du vill.",
                    ""));
            songs.Add(new Song("Regissörens skål", "", "", "Tystnad... Tagning!",
                    ""));
            songs.Add(new Song(
                    "Sista supen",
                    "Melodi: Väva vadmal",
                    "",
                    "Krök armen i vinkel! \n Här vankas det finkel. \n Och finka vankel och vanka finkel, \n och kröka armen i vinkel. \n Här vankas det finkel!",
                    ""));
            songs.Add(new Song("Titta taket", "", "", "Titta, taket!", ""));
            songs.Add(new Song("Farväl, farväl",
                    "Melodi: En sjöman älskar havets våg", "",
                    "Farväl, farväl, förtjusande sup,\n men kom inte upp igen!", ""));
            songs.Add(new Song(
                    "Hyfsvisa",
                    "",
                    "",
                    "Kors i allsin dar!\n Har du brännvin kvar?\n Är du sparsam eller snål?\n Skål!",
                    "Sparsamma sjunger 'Snål!'"));
            songs.Add(new Song("Jag äter inte klockor",
                    "Melodi: Det var en lørdag aften", "",
                    "Jag äter inte klockor,\n men dricker gärna ur.", ""));
            songs.Add(new Song(
                    "Gräv ur tundran",
                    "Melodi: Katjuscha",
                    "Text: Kenneth Hagås",
                    "Gräv ur tundran två dussin potäter,\n låt dem jäsa uti fjorton dar.\n ||: Modersmjölken för ryssar och sovjeter\n brännes i babusjkas samovar :||\n \n Kyl sen drycken i Sibiriens tjäle,\n tappa upp på immiga små glas.\n Höj sen glasen för fosterlandets välgång,\n sjung Nastarovja med en mäktig bas!\n Höj sen glasen för fosterlandets välgång,\n sjung Nastarovja –\n låt glasen gå i kras!",
                    "Den här visan skrevs till ekonomspexet 'Lenin eller Gossplanen eller Wanted; Red or alive' 1989. Den blev så uppskattad att den numera ofta sjunges som sista nubbevisa. Första versen och andra fram till 'Höj sen...' sjunges viskande. På 'Höj' höjes även rösten. Meningen är att nubbeglaset kastas över vänster axel efter supen, men det görs av förklarliga skäl aldrig. Nubbeglas i plast brukar däremot krossas i handen på ordet 'kras'."));
        }

        if (type == SongType.Öl)
        {

            /* ÖL */
            songs.Add(new Song(
                "Der var en skikkelig bondemand",
                "",
                "",
                "||: Der var en skikkelig bondemand,\n han skulle ud efter øl. :||\n Han skulle ud efter øl,\n han skulle ud efter øl, efter øl,\n efter hopsasa, tralalala,\n han skulle ud efter øl.\n \n ||: Til konen kom der en ung student,\n mens manden var ud' efter øl. :||\n Mens manden var ud' efter øl...\n \n ||: Han klapped' hende på rosenkind\n og kyssed' hende på mund. :||\n Mens manden var ud' efter øl...\n \n ||: Men manden stod bag ved døren og så,\n hvordan det hele gik til. :||\n For de trod' han var ud' efter øl...\n \n ||: Så skød han studenten og kællingen med,\n og så gik han ud efter øl. :||\n Og så gik han ud efter øl...\n \n ||: Moralen er: Tag din kone med,\n hver gang du skal ud efter øl. :||\n Hver gang du skal ud efter øl...",
                "Dette er en gammel skæmtevise, som var kendt allerede i 1500-tallets Tyskland under navnet 'Es hatt ein Bauer ein junges Weib'."));
            songs.Add(new Song(
                    "Ölvisan",
                    "Melodi: SJ, SJ gamle vän",
                    "",
                    "Dricka pilsner varje da'\n det är kul å det e bra.\n Ja, det borde alla ha,\n en pilsner varje da'.\n \n Öl det slinker ner så lätt\n lättare än fläskkotlett.\n Å när en har slunkit ner\n så måste man ha fler.\n \n Efter sex, sju flaskor till\n blir det svårt att sitta still.\n Å vid cirka trettitvå\n så blir det svårt att gå.\n \n Öl de e ju faktiskt mat,\n öl på burk å öl på fat.\n Måste fyllas på i ett\n för annars går det snett.\n \n Ingen har väl illa mått\n utav öl som e så gott.\n Den som ändå detta gjort\n har druckit det för fort.\n \n Korka upp din öl å drick\n så blir du en festlig prick.\n Korka upp å drick min vän\n å rapa högljutt sen.",
                    ""));
            songs.Add(new Song(
                    "Min pilsner",
                    "Melodi: My Bonnie",
                    "",
                    "Min pilsner ska svalka min tunga,\n min pilsner ska duscha min gom.\n Min pilsner ska få mig att sjunga,\n om jag ser att flaskan är tom:\n Pilsner! Pilsner!\n Hämta en pilsner till mig, till mig.\n Pilsner! Pilsner!\n Hämta en pilsner till mig!",
                    ""));
            songs.Add(new Song(
                    "Ode till ölet",
                    "Melodi: Trampa på gasen",
                    "",
                    "Tu tu tu Tuborg och ca ca ca Carlsberg,\n det är den bästa pi pi pi pilsnern som jag vet.\n \n Tu tu tu Carlsberg och ca ca ca Tuborg,\n det är det bästa pi pi pi ölet som jag vet.\n \n Tu tu tu ölberg och ca ca ca pilsborg,\n det är den bästa pi pi pi biran som jag vet.",
                    ""));
            songs.Add(new Song(
                    "When I get drunker",
                    "Melodi: When I'm 64",
                    "",
                    "When I get drunker, losing my mind\n many beers from now.\n Will I still be having me a jolly good time,\n whisky, gin and a bottle of wine.\n So, fill up the glasses, drunk as a skunk,\n don't say you want no more,\n 'cause we are the singers\n and we are the swingers,\n join us and you won't get bored.",
                    ""));
            songs.Add(new Song(
                    "En pilsnerdrickare",
                    "Melodi: En sockerbagare här bor i staden",
                    "",
                    "En pilsnerdrickare här bor i staden,\n han dricker pilsner mest hela dagen,\n han dricker gröna, han dricker blå,\n han dricker några med renat på.\n \n Och i hans fönster hänga tomma glasen,\n och alla burkarna ifrån kalasen,\n och är han nykter så kan han gå\n ner till butiken och fylla på.",
                    ""));
            songs.Add(new Song(
                    "Vi älskar öl",
                    "Melodi: Ser du stjärnan i det blå?",
                    "",
                    "Täckt av silver sejdeln full\n gnistrar mot oss med sitt guld.\n Humle, malt är livets salt, vi älskar öl.\n \n Källarsval så bärs den in\n för att glädja gommen din,\n släcka törsten, stärka rösten, till dess lov.\n \n Knubbig blir du, men so what,\n gott och roligt har du fått\n extraturen, rensat njuren, öl är gott.",
                    ""));
            songs.Add(new Song(
                    "Sanningen om ölet",
                    "Melodi: Här är gudagott att vara",
                    "",
                    "Öl är gudagott att dricka.\n O, vad öldrycken dock är skön.\n Dricka öl med älskad flicka\n billigare än likören grön.\n Humlan surrar, flickan strålar,\n nu går jag och slår en drill.\n Lättad, törstig, sedan jag skålar\n i gott öl min flicka till.",
                    ""));
            songs.Add(new Song(
                    "Drömmen om ölen",
                    "Melodi: Drömmen om Elin",
                    "",
                    "Nu så har vi fest.\n Det går sång ur alla strupar.\n Ölen är vår gäst,\n ibland sill och supar.\n Tredje klass ger mest,\n och om du blir trött och stupar:\n drömmen om ölen låter dig festa igen!\n \n På vårt ölkalas,\n där finns inga fat och koppar.\n Stora sejdelglas\n helt servisen toppar.\n När den sista tas,\n och du själv går hem och knoppar:\n drömmen om ölen låter dig festa igen!",
                    "Från Linköpingsspexet 'En bror för mycket eller de Gama och havet' 1988."));
            songs.Add(new Song(
                    "La oss dricke",
                    "Melodi: Änkevalsen ur Glada änkan",
                    "",
                    "Gamle venner halsen brenner\n Øl - øl - øl.\n Hvilken väske kan oss leske?\n Øl - øl - øl.\n Er vår sang enn ikke ren og klar som sølv,\n la oss dricke, la oss dricke.\n Øl - øl - øl.",
                    ""));
            songs.Add(new Song(
                    "Ju mera öl vi dricker",
                    "Melodi: Ju mer vi är tillsammans",
                    "",
                    "Ju mera öl vi dricker,\n vi dricker, vi dricker,\n ju mera öl vi dricker,\n ju rundare vi bli.\n För rundare är sundare\n och sundare är rundare.\n Ju mera öl vi dricker,\n ju rundare vi bli.",
                    ""));
            songs.Add(new Song(
                    "Ölet som försvann",
                    "Melodi: Elvira Madigan",
                    "",
                    "Sorgeliga saker hända,\n än i våra dar minsann.\n Sorgeligast är dock denna,\n den om ölet som försvann.\n \n Aldrig nånsin skall vi glömma\n mellanölets äventyr.\n För att nu om ölet drömma\n helt vi oss till spriten tyr.",
                    ""));
        }

        if (type == SongType.Vin)
        {

            /* VIN */
            songs.Add(new Song(
                "Feta fransyskor",
                "Melodi: Schuberts Marche Militaire",
                "",
                "Feta fransyskor som svettas om fötterna\n de trampa druvor som sedan ska jäsas till vin.\n Transpirationen viktig e'\n ty den ger fin bouquet.\n Vårtor och svampar följer me'\n men vad gör väl de'?\n \n För... vi vill ha vin, vill ha vin, vill ha mera vin!\n Även om följderna blir att vi må lida pin.\n Damerna: Flaskan och glaset gått i sin.\n Herrarna: Hit med vin, mera vin!\n Damerna: Tror ni att vi är fyllesvin?\n Herrarna: JA! (Fast större)",
                "Skriven av K-LTH till Sångarstriden 1985. Enligt legenden var de två sista orden enbart riktade till personen som skulle trycka upp sångbladen."));
            songs.Add(new Song(
                    "Sudda, sudda",
                    "",
                    "",
                    "Sudda, sudda, sudda, sudda bort din sura min,\n med fyra jättestora bamseklunkar ädelt vin.\n Munnen den ska sjunga och va' glad\n för att den ska bli som den ska va.\n Vad häller du då bak det dolda flinet? Vinet!\n Som suddar, suddar bort din sura min.",
                    ""));
            songs.Add(new Song(
                    "Bordeaux, bordeaux",
                    "Melodi: I sommarens soliga dagar",
                    "",
                    "Jag minns än idag hur min fader\n kom hem ifrån staden så glader\n och rada' upp flaskor i rader\n och sade nöjd som så: Bordeaux, Bordeaux.\n Han drack ett glas,\n kom i extas,\n och sedan blev det stort kalas.\n Och vi små glin,\n ja, vi drack vin,\n som första klassens fyllesvin.\n Och vi dansade runt där på bordet\n och skrek så vi blev blå: Bordeaux, Bordeaux!",
                    ""));
            songs.Add(new Song(
                    "Pussvisa",
                    "Melodi: Längtan till landet",
                    "",
                    "Vintern rasat enligt alla källor\n våren kommer när den nu får tid.\n Men vi har ju vin och vackra fjällor\n och vi kysser den vi har bredvid.\n \n Här kan man passa på att pussa någon...\n \n Snart är vinet där det gör någon nytta\n om du bara fattar glaset i hand.\n Vänd det upp och ned, som rakt i en bytta,\n tänk dig nu att strupen står i brand!",
                    ""));
            songs.Add(new Song(
                    "Rhenvinets lov",
                    "Melodi: Strömt herbei, ihr Völkerscharen",
                    "Text: R Palmé",
                    "Ställ nu fram i källarsalen\n av den dunkelgröna färg\n härligt glänsande pokalen,\n fylld av ädla druvans märg.\n Ty blott rhenvin vill jag dricka,\n nöjd och glad i samma stund\n ||: när mot mig dess pärlor blicka\n från pokalens vida rund. :||\n \n Under Spaniens sol måhända\n färgas druvan mera röd,\n må champagnens eldflod tända\n i mitt bröst passionens glöd,\n men det rhenska vin ej rusar,\n sans och måtta bo däri,\n ||: och vårt sinne milt det tjusar\n likt en älskad melodi. :||\n \n I min ungdoms fröjd och gamman\n som i mannaåren än,\n detta vinet band mig samman\n med så mången trogen vän.\n Därför när mig döden nalkas,\n förr'n min kropp blir lagd i skrin,\n ||: av en droppe låt mig svalkas\n av det ädla rhenska vin. :||",
                    ""));
            songs.Add(new Song(
                    "Röd vitamin",
                    "Melodi: My Bonnie",
                    "",
                    "Hur badar man bäst på en kurort?\n Jo, om man har fyllt en bassäng\n med vätskan som snart skall besjungas\n när vi kommit fram till refräng.\n \n Rödvin, rödvin\n rödvin är fin hälsokost, kost, kost.\n Rödvin, rödvin,\n rödvin vår bästa flaskpost.\n \n Man får vitaminer från rödvin,\n man piggnar ju till på en gång.\n När glaset har tömts uti botten\n så stämmer vi upp till en sång.\n \n Rödvin, rödvin...",
                    ""));
            songs.Add(new Song(
                    "Till vinet",
                    "Melodi: Flickan i Havanna",
                    "",
                    "Flickan vid din sida,\n hon har ännu vinet kvar.\n Sitter nu och väntar\n att en skål vi tar\n Hej, du kära vännen min,\n drick nu ur ditt goda vin.\n Glas blir tomt och du blir full,\n skål mitt hjärtegull.",
                    ""));
            songs.Add(new Song(
                    "Festen kan börja",
                    "Melodi: Vårvindar friska",
                    "",
                    "Festen kan börja, ingen får sörja\n här finns ju både rödvin och mat.\n Vinet skall tömmas, sorgerna glömmas,\n ingen får vara tråkig kamrat.\n \n Klappa mitt hjärta, fröjdas min själ,\n vinet serveras genast nåväl.\n Fatta nu glaset, börja kalaset,\n skål allesammans, skål!",
                    ""));
            songs.Add(new Song(
                    "Se vinet väntar",
                    "Melodi: Svarte Rudolf",
                    "",
                    "Se vinet väntar i glaset,\n men väntan skall inte bli lång.\n För skall det bli sprätt på kalaset\n skall vinglaset tagas med sång.\n Vår sång ädla känslor framföder\n och skapar en festatmosfär.\n Lyft bägaren, systrar och bröder,\n vi firar att just vi är här!",
                    ""));
            songs.Add(new Song(
                    "Kvinnans skål",
                    "Melodi: Fjäriln vingad",
                    "",
                    "Skål för kvinnan vill vi dricka,\n hon som har oss alla i hand.\n Vad är pojken utan flicka?\n Blott en något äldre ensam man.\n Kvinnans väsen här vid bordet\n har åt kvällen givit glans.\n Låt oss anta hur det vore;\n utan kvinnan ingen av oss fanns.",
                    ""));
            songs.Add(new Song(
                    "Mannens skål",
                    "Melodi: Fritiof och Carmencita",
                    "",
                    "Kvinnor gemensamt tar en skål här nu vid bordet\n riktad till mannen, han som nästan jämt har ordet.\n Fast han är härlig, om än lite besvärlig,\n vore livet förutan honom mycket grått och trist.\n För det är faktiskt så att mannen har nåt visst\n något som vi kvinnor gillar.\n \n Styrka och charm och gott humör\n och en förmåga att ofta förstå varför\n kvinnor väntar sig att han skall göra\n allt vad kvinnan vill.\n Därför vi skåla för honom.",
                    ""));
            songs.Add(new Song(
                    "Så länge rösten är mild",
                    "Melodi: Så länge skutan kan gå",
                    "",
                    "Så länge rösten är mild,\n så länge ingen är vild.\n Så länge spegeln på väggen\n ger halvskaplig bild.\n Så länge alla kan gå,\n så länge alla kan stå,\n så länge alla kan tralla - så fyller vi på.\n \n För vem har sagt att just du kom med storken,\n för att bli glad av att lukta på korken?\n Men kring vårt bord här nånstans,\n vi höjer bägarn med glans,\n och låter vinet gå ner i en yrande dans.",
                    ""));
            songs.Add(new Song(
                    "Till rödvinet",
                    "Melodi: En gång jag seglar i hamn",
                    "",
                    "En sång, det är ingen sång\n om inte på samma gång\n man tar ett glas i sin hand\n och får på tand\n en pärla ibland.\n Druva, vi varmt dig nu be:\n ljuva minuter oss ge.\n Än är vi unga,\n sjung och glamma och le.",
                    ""));
            songs.Add(new Song(
                    "Damernas skål",
                    "Melodi: Svarte Rudolf",
                    "",
                    "Nu rödvin gnistrar i bägar'n,\n jag lyfter den sakta och ler.\n Och blicken liksom vilde jägarn\n den löper längs bordsranden ner.\n Att söka kontakt med det sköna \n det lär vara herrarnas mål.\n Så'nt blickfång det borde sig löna \n med slagordet 'Damernas skål'.\n \n Nu rödvin gnistrar i bägar'n,\n jag höjer den sakta och ler\n åt fläckarna på vita skjortan\n där rödvinet har runnit ner.\n Jag struntar i fläckarnas storlek\n om än de var stora som torg.\n Klorin är det bästa mot rödvin\n och rödvin det bästa mot sorg.",
                    ""));
            songs.Add(new Song(
                    "När det strålar uti salen",
                    "Melodi: Fjäriln vingad",
                    "",
                    "När det strålar uti salen\n utav glädje, glans och färg.\n När det gnistrar i pokalen\n utav ädla druvans märg.\n \n Kära vänner, varför dröja\n med att dricka glädjen till?\n Låt oss bort från framtids slöja\n se allt skönt vi skåda vill.\n \n Drick för allt vad livet skänker\n glädjestunder, ljus och sol.\n Drick för stjärnorna som blänker\n över oss från pol till pol.\n \n Drick för åren, väl du kan det.\n Drick för kärlek åren ger.\n Drick för starka vänskapsbanden.\n Drick för allt vad skönt du ser.",
                    ""));
        }

        if (type == SongType.Punsch)
        {

            /* PUNSCH */
            songs.Add(new Song(
                "Punschen kommer (kall)",
                "Melodi: Änkevalsen ur Glada änkan",
                "",
                "Punschen kommer, \n punschen kommer,\n ljuv och sval.\n Glasen imma, röster stimma\n i vår sal.\n Skål för glada minnen!\n Skål för varje vår!\n Inga sorger finnas mer\n när punsch vi får.",
                ""));
            songs.Add(new Song(
                    "Punschen kommer (varm)",
                    "Melodi: Änkevalsen ur Glada änkan",
                    "",
                    "Punschen kommer,\n punschen kommer,\n god och varm.\n Vettet svinner, droppen rinner\n ner i tarm.\n Skål för alla minnen!\n Dem vi snart ej ha.\n Då ett glas med simmig punsch\n vi hunnit ta.",
                    "Sjunges under utförande av diverse rörelser fram till dess man fått sin punsch, då slutar man sjunga så att serveringspersonalen lätt kan se vilka gäster som fortfarande väntar på de gula dropparna."));
            songs.Add(new Song(
                    "Djungelpunsch",
                    "Melodi: Var nöjd med allt som livet ger",
                    "",
                    "Jag gillar alla tiders punsch.\n Punsch till frukost, punsch till lunch,\n en punsch till förrätt, varmrätt och dessert.\n Jag gillar punsch för vet du va',\n rent kaffe gör ju ingen gla'.\n Nej, punsch för fulla muggar vill jag ha.\n \n Med konjak du lockar.\n Den bästa Renault.\n Förlåt om jag chockar\n och tar punsch ändå.\n Och bjuder du på fin likör\n får du ursäkta om det stör.\n Jag väljer hellre Grönsteds Blå,\n en Cederlunds eller Flaggpunsch å\n - kanske har du ren Platin?\n Jag gillar punsch,\n ger du mig punsch så är jag din.\n För evigt din.",
                    ""));
            songs.Add(new Song(
                    "Studiemedelsrondo",
                    "Melodi: Vi lossa sand",
                    "",
                    "||: Vi dricker punsch\n till lunch,\n när vi har fått avin.\n Vi lunchar hela dagen\n tills kassan gått i sin. :||",
                    ""));
            songs.Add(new Song(
                    "Gul lyser solen",
                    "Melodi: Lili Marlene",
                    "",
                    "Gul lyser solen,\n gult är flaggans kors,\n gul vajar säden\n och gul är ängens pors.\n Gul är kinesen,\n gul japan,\n och pyttens ägg\n är gult som fan.\n Vår punsch är gul så ta'n,\n vår punsch är gul så ta'n.",
                    ""));
            songs.Add(new Song(
                    "Lilla punschvisan",
                    "",
                    "",
                    "Det var en gång jag tänkte\n att punschen övergiva,\n men det blir aldrig av\n så länge jag får leva.\n För när jag en gång dör\n så står det på min grav:\n 'Här vilar en som\n svenska punschen älskat har'.\n \n Jag gillar, jag gillar punschen,\n jag gillar den som punschen skapat har.\n Jag gillar, jag gillar punschen,\n jag gillar punschen och dess far.",
                    "Här brukar följa ett varierande antal tilläggsverser."));
            songs.Add(new Song(
                    "Punschkanon",
                    "",
                    "",
                    "Herrarna:\n ||: Punsch, punsch, punsch, punsch,\n punsch, punsch, alla sorters :||\n \n Damerna:\n När supen runnit hädan\n och maten lagts därpå,\n och kaffet står på bordet,\n vad väntar vi då på?\n ||: Jo punsch, jo punsch\n och ännu mera punsch. :||\n \n Ja, den föll oss i smaken,\n nu ropar vi gutår,\n och koppen står där naken\n och väntar på påtår.\n ||: Jo punsch, jo punsch\n och ännu mera punsch. :||",
                    ""));
            songs.Add(new Song(
                    "Änglapunsch",
                    "Melodi: Änglamark",
                    "",
                    "Kalla den gudagåva eller himlanektar,\n vad du vill.\n Punschen den gyllne, de gamle oss skänkte.\n Vet att så länge som punschen nå'nsin funnits till\n glädjen den höjde och sorgerna dränkte.\n \n Blunda och dröm om en blommande sommarnatt\n svala bersåer där punschen står immig.\n Eller en höstdag när Nordan har lekt tafatt,\n varm punsch som ångar och ärtsoppa simmig.\n \n Punschen den älskas ju av alla och envar.\n Låt festen börja - låt punschen få flöda!\n Skål alla vänner som har nå't i glaset kvar,\n hedra nu minnet av gamle kung Oscars da'r!\n \n Kalla den gudagåva eller himlanektar, vad du vill.\n Punschen den gyllne, som får oss att drömma.\n Fukta din strupe, låt inte flaskan få stå still,\n skåla för punschen och glasen vi tömma!",
                    ""));
            songs.Add(new Song(
                    "Härlig är punschen",
                    "Melodi: Härlig är jorden",
                    "",
                    "Härlig är punschen,\n härlig är dess konsistens.\n Skönt är att taga den än en gång.\n Genom att taga punschen av daga\n gå vi till paradis med sång.",
                    ""));
            songs.Add(new Song(
                    "Punsch, punsch",
                    "Melodi: Ritsch, ratsch, fillibom",
                    "",
                    "Punsch, punsch fillibom-bom-bom,\n fillibom-bom-bom, fillibom-bom-bom.\n Punsch, punsch fillibom-bom-bom,\n fillibom-bom-bom, fillibom.\n Vi har ju både Cederlunds och Carlshamns Flagg\n och Grönstedts blå och lilla Caloric.\n Det blir för trist med sodavatten,\n sodavatten, sodavatten.\n Det blir för trist med sodavatten.\n Ge mig mera punsch!",
                    ""));
            songs.Add(new Song(
                    "Punschens lov",
                    "Melodi: Rövarna i Kamomilla stad",
                    "",
                    "Ja, punschen är och punschen var\n och punschen skall förbliva\n en lidelse vi alla har\n som inget kan fördriva.\n Ja, punschen tinar upp såväl\n och svalkar både kropp och själ.\n Den botar begären\n och lindrar besvären,\n ja, punschen den gör både gott och väl.",
                    "Från Kårspexet 'Sven Hedin eller en enkel tur och retur' 1987."));
            songs.Add(new Song(
                    "Punschvisa",
                    "Melodi: Med en enkel tulipan",
                    "",
                    "Nu med en ny och stadig krök\n med armen gör vi försök\n att lyfta koppen, att lyfta koppen\n som står och väntar.\n Håll blicken fäst vid koppens rand \n och darra inte på hand.\n Nu allesammans, nu allesammans\n på munnen gläntar.\n En liten punschtår så här placerad\n i ena handen sig bättre gör \n än tio liter uppå Systemet\n och inga pengar att köpa för.\n Spill inga droppar på ditt bord\n och spill ej mer några ord.\n Nu tar vi punschen, nu tar vi punschen \n som står och väntar.",
                    ""));
            songs.Add(new Song(
                    "Giv oss vår punsch",
                    "Melodi: God save the Queen",
                    "",
                    "Giv oss vår punsch idag,\n den som är sval och bra,\n eller väl värmd.\n Glasen vi tömma här,\n det blir en glad affär,\n för vi ska ha mera punsch.\n Vi är här se'n lunch.",
                    ""));
            songs.Add(new Song(
                    "Min älskling",
                    "Melodi: Min älskling du är som en ros",
                    "",
                    "Min älskling du är som en punsch,\n en nyupphälld och kall.\n Ack, som en Cederlunds så ljuv,\n min älskling, jag är knall.\n \n Så underbar blir du av punschen,\n och ser så vacker ut.\n Att älska dig det skall jag än\n när punschen tagit slut.\n \n När hela flaskan står där tom\n och torkan i min gom\n härjar så brännande och from,\n då fäller jag min dom.\n \n Min älskling du är som en punsch,\n en flaska Cederlundsch.\n Ack, jag vill bara älska dig,\n min älskling och min punsch!",
                    ""));
            songs.Add(new Song(
                    "FestUs punschvisa",
                    "Melodi: Tomtarnas julnatt",
                    "",
                    "Punschen, punschen rinner genom strupen,\n ner i djupen.\n Blandas, konfronteras där med supen,\n där med supen.\n Gula droppar stärker våra kroppar:\n punsch, punsch, punsch.",
                    ""));
            songs.Add(new Song(
                    "Kaffe, kaffe, kaffe",
                    "Melodi: Du ska få min gamla cykel när jag dör",
                    "",
                    "Vi har ätit och vi mår så väldans bra\n och nu vill nog alla säkert kaffe ha.\n Snart så får vi höra stönen\n när vi sjunger kaffebönen.\n Det ska höras ända bort till nästa sta'.\n \n Kaffe, kaffe, kaffe, konjak och likör\n ger åt alla här ett mycket glatt humör.\n Och det kan ni ge er katten\n vi ska sitta hela natten\n dricka kaffe, kaffe, konjak och likör.\n \n Ofta får man höra ordet kaffetant\n husets herre säger gärna helt galant\n Du min rara, du min sköna, \n älskar du din kaffeböna\n mer än mej, det kan väl inte vara sant?\n \n Kaffe, kaffe, kaffe...\n \n Calle Schewen blanda kaffet sitt med Kron.\n Det var medicin, han hade denna tron.\n Och man blir ju allt en rask en\n när man dricker kaffekasken.\n Jublar högt i skyn och sedan tar man ton.\n \n Kaffe, kaffe, kaffe...\n \n Uti alla väder smakar fikan gott\n och hos damer tungan ofta får så brått\n och man skulle nog bli häpen \n om man kom på kafferepen\n munnen går som om den vore smord med flott.\n \n Kaffe, kaffe, kaffe...",
                    ""));
            songs.Add(new Song(
                    "Tvekan inför punschen",
                    "Melodi: Rosa på bal",
                    "",
                    "Jag borde nog inte dricka mer\n varken öl eller vin eller brännevin.\n En kaffetår blott, men såvitt jag ser\n står det punsch brevi'n.\n \n Tänk vilken underbar färg och odör.\n Nej, det blir bara man bråkar och stör.\n Men för att inte min kväll skall bli trist,\n krävs både slughet och list!\n \n Så jag tror nog att jag tar en\n punsch, kanske två, kanske tre!\n Se'n blir det groggar i baren,\n jag klarar säkert av det!\n \n Trots att jag egentligen är rätt knall,\n piggar nog punsch upp mig i alla fall.\n Jag kvicknar till med en punsch i min bål.\n Nu har jag bestämt mig, skål!",
                    ""));
            songs.Add(new Song(
                    "Nya punschvisan",
                    "Melodi: Mjölnarens dotter",
                    "",
                    "Vad ger dig din sisu, vad håller dig varm?\n Skororompompej!\n Jo, punschen som upptas i mage och tarm.\n Försvinnande god!\n Försvinnande god!\n Får upp humöret och promillen, hej!\n \n Du blir som en ny män'ska om du tar en punsch.\n Skororompompej!\n Och den nya män'skan vill också ha en punsch.\n Försvinnande god!\n Försvinnande god!\n Får upp humöret och promillen, hej!",
                    "Ur Chalmersspexet 'Sven Duva' 1965."));
            songs.Add(new Song(
                    "Vädjan till punschen",
                    "Melodi: Sov du lilla videung",
                    "",
                    "Kom nu lilla punschen min,\n följ nu efter supen. \n Snart så skall du åka in\n ner igenom strupen,\n till mitt stora magpalats,\n där det finns så mycket plats.\n Kom nu lilla punschen,\n följ nu efter supen.",
                    ""));
            songs.Add(new Song(
                    "Johansson är ful",
                    "Melodi: Kostervalsen",
                    "",
                    "Johansson är ful,\n han får gömma sig i ett skjul.\n Ful är Perssons bror,\n Persson själv har glömt var han bor.\n Fulhet gör mig trött,\n ge mig snabbt någonting som är sött!\n Ge mig punsch,\n ett glas med punsch,\n nej, en flaska med punsch!\n (Å' en kasse bärs.)",
                    ""));
            songs.Add(new Song(
                    "Punschschottis",
                    "Melodi: Schottis på Valhall",
                    "",
                    "Uppå bordet står nu en liten tår,\n den har lyster precis som kristall.\n Den är lockande, den är pockande,\n och fast den är isande kall,\n den oss värme ger när den slunkit ner\n i en dammig och torr liten hals.\n Det är punschen som går,\n det är punschen som får\n hela livet att bli till en vals.",
                    ""));
            songs.Add(new Song(
                    "Ärter och punsch",
                    "Melodi: Fritiof och Carmencita",
                    "",
                    "Ärter och punsch, en liten rätt med traditioner.\n Den smakar bra och väcker många sensationer.\n Blekgul till färgen, smaken går in till märgen,\n med en senap som blandas enligt gammal tradition,\n så ska den njutas denna svenska folks passion,\n en torsdagskväll i varje månad.\n \n Skål nu vänner uti denna mäss,\n ärter och punsch ska vi njuta utan stress.\n Inga sura miner vill vi se i afton,\n när doften utav ärter och punsch sprids i salongen.\n Tänk på Grönstedt, Cederlund och Flagg,\n åh, vilken doft från denna arraksgula tagg.\n Hela natten ska vi njuta denna underbara brygd,\n skål för lilla ärten och punschen.",
                    ""));
            songs.Add(new Song(
                    "Visa vid torsdagskväll",
                    "Melodi: Visa vid midsommartid",
                    "",
                    "Du häller ur flaskan en gyllene tår,\n av punsch ifrån Cederlunds.\n Du lyfter se'n bägar'n och väl du förstår,\n att föra den till din mun.\n Ikväll skall du dricka ditt livselixir\n och känna den ljuva punschen liksom ett vårbjörkeskir.\n I natt skall du bäras av Razor på bår,\n och kallas för fyllehund.",
                    ""));
            songs.Add(new Song(
                    "Sista punschvisan",
                    "Melodi: Auld lang syne",
                    "",
                    "När punschen småningom är slut\n och vår flaska blivit tom,\n då vänder vi den upp och ner\n till dess inget rinner ur.\n \n ||: Så slickar vi, så slickar vi\n båd' utanpå och i,\n och finns det ändå något kvar\n får det va' till sämre dar. :||",
                    ""));
        }

        if (type == SongType.Kräftor)
        {

            /* KRÄFTOR */
            songs.Add(new Song(
                "Kräftvisa",
                "Melodi: Studentsången",
                "",
                "Nykokta kräftor, nyslagen dill,\n fem liter brännvin och sjuhundra pilsner.\n Rödaste skal är ju bättre än sill.\n Särskilt om man får supen därtill.\n Skal kring stjärt och klor,\n döljer dock smaken, bror.\n Men ingen möda stor,\n dess skal skall brytas opp,\n och aromen skall in i vår kropp.\n Helan tömmer vi snabbt till dess klor,\n Halvan tar vi sen tvärt till dess stjärt.\n Hurra!",
                ""));
            songs.Add(new Song(
                    "Små nubbarna",
                    "Melodi: Små grodorna",
                    "",
                    "Små nubbarna,\n små nubbarna,\n är lustiga att ta.\n Små nubbarna,\n små nubbarna,\n dom vill vi gärna ha.\n Ej röra, ej röra,\n nej, skala kräftan först\n och sedan, och sedan,\n vi släcka ska vår törst.",
                    ""));
            songs.Add(new Song(
                    "Kräftor ätas",
                    "",
                    "",
                    "Kräftor ätas uti sen augustikväll.\n Strupar vätas med nånting ur en putäll.\n Lyften glasen, klara basen\n så i stämning vi kan bli.\n Kräftkalasen de är fina, tycker vi.\n \n Läckert röda våra skaldjur ligga här.\n Utan möda ett par tjog vi friskt förtär.\n Glasen imma, kräftor simma\n bäst i brännvin, som ni vet.\n Lyktor glimma känsligt mot all härlighet.\n \n Första tjoget kravlat ner i magens djup.\n I begravningståget gick en fattig sup.\n Så att Tersen här i versen\n kommer före nummer två.\n Tål ni pärsen tar vi Halvan ovanpå.",
                    ""));
            songs.Add(new Song(
                    "Kräfta, kräfta prydd med dill",
                    "Melodi: Blinka lilla stjärna",
                    "",
                    "Kräfta, kräfta prydd med dill\n och en immig sup därtill,\n bröd och smör och ost och sill,\n och så några supar till.\n Kräfta, kräfta prydd med dill,\n nu vi fått allt vad vi vill.",
                    ""));
            songs.Add(new Song(
                    "Kräftorna sköna",
                    "Melodi: Vårvindar friska",
                    "",
                    "Kräftorna sköna,\n dillkronor gröna,\n lysa så grant bland blommor och bla'r.\n Nubbarna ila,\n finna ej vila,\n förrän i magen störtvågen far.\n Gläd dig min mage,\n håll dig beredd,\n Helan vi tage,\n på längd och bredd.\n Och lilla snapsen\n dyker så rapp sen\n ner i sin sköna bädd.",
                    ""));
            songs.Add(new Song(
                    "Stänk utav sälta",
                    "Melodi: Mors lille Olle",
                    "",
                    "Stänk utav sälta och doft utav dill,\n lyktor som lysa i höstkvällen still.\n Sorl utav röster och klirr utav glas,\n tiden är inne för kräftans kalas.\n \n Innan vår värld har gått under med brak,\n ville jag föreslå eder en sak:\n glädoms åt kräftan och drickom nu till,\n skaldjurens drottning med krona av dill.",
                    ""));
            songs.Add(new Song(
                    "Kräftor kräva dessa drycker",
                    "Melodi: Räven raskar över isen",
                    "",
                    "Kräftor kräva dessa drycker.\n Kräftor kräva dessa drycker.\n En liten snaps till varje klo,\n det är för strupen en lisa.\n Så här gör kräftvännen när det står\n kräftor på bordet och när han får\n en liten snaps till varje klo.\n Nu är det slut på vår visa.",
                    ""));
            songs.Add(new Song(
                    "Kvällens klo",
                    "Melodi: Milord",
                    "",
                    "Oh, vilken klo, milord,\n den är så stor och hård.\n Vi hoppas alla att den aldrig ska ta slut.\n Den är så fin, milord,\n nu blir det världsrekord,\n nu ska vi suga tills det goda kommer ut.",
                    ""));
            songs.Add(new Song(
                    "Kräftklon",
                    "Melodi: Vi gå över daggstänkta berg",
                    "",
                    "Till kräftklon man tager en sup - sup - sup,\n som letar sig ner i magens djup - djup - djup.\n Och den som börjar tveka,\n om detta var en räka,\n han tar sig ytterligare en sup - sup – sup.",
                    ""));
            songs.Add(new Song(
                    "Vi går mot de dillprydda berg",
                    "Melodi: Vi gå över daggstänkta berg",
                    "",
                    "Vi går mot de dillprydda berg, fallera,\nsom lånat av rubinerna sin färg, fallera.\nSå skön på stora faten\nligger kräftan, gudamaten,\nvilken stärker och styrker vår märg, fallera!\n\nMan gärna har levt i den tron, fallera,\natt kräftor kräva O.P. eller Kron, fallera.\nMen råkar du det sakna\nså låt ej glädjen slakna,\nnjut ändå utav stjärten eller klon, fallera!\n\nVisst kräftan är dyr uti pris, fallera,\noch säljs nu till på köpet kilovis, fallera.\nDock svär jag vid min lyra,\nkräftor kan ej bli för dyra,\nty det finns ingen liknande spis, fallera!\n\nOch därför så måste vi ta, fallera,\nför kräftorna ett rungande hurra. Hipp hurra!\nTy livet blommar just i\nfagra månaden augusti,\ndå vårt månsken och kräftor vi ha, fallera!\n\nSå fattom ett glas i vår hand, fallera,\noch tagom då och då en tår på tand, fallera.\nFör klon vi tager tvärt en\nsup och sedan två för stjärten,\nty vi måste ju festa ibland, fallera!",
                    ""));
            songs.Add(new Song(
                    "Kräftan kommer, kräftan går",
                    "Melodi: Kovan kommer, kovan går",
                    "",
                    "Kräftan fordrar nubbar små,\nnubbar små, nubbar små.\nAnnars börjar den att gå,\nden att gå, den att gå.\nUti magen din den kryper\noch i tarmarna dig nyper.\nDetta är ett ofint sätt,\nsvälj nu nubben fort och lätt.\n\nKräftan är ett läckert djur,\nläckert djur, läckert djur.\nFärgen den går aldrig ur,\naldrig ur, aldrig ur.\nGår den bakåt är den okokt.\nGår den framåt är det oklokt,\natt du tar en pärla till,\nmen du gör ju som du vill.\n\nKräftorna har hårda skal,\nhårda skal, hårda skal.\nJordgubbar har lösa skal,\nlösa skal, lösa skal.\nDetta för att på dem skilja,\nmed den allra sista vilja.\nEfter tersen i kvadrat:\ngott det är med lite mat.",
                    ""));
            songs.Add(new Song(
                    "Våran kräfta",
                    "Melodi: Gubben Noak",
                    "",
                    "Våran kräfta,\nvåran kräfta,\nhar båd' klo och stjärt.\nKlon den ska vi knäcka,\nstjärten ska vi spräcka.\nSedan supen\nner i strupen\nhäller vi så tvärt.",
                    ""));
            songs.Add(new Song(
                    "Å kräftan å ja",
                    "Melodi: Jänta å ja",
                    "",
                    "Å kräftan å ja', å kräftan å ja',\nvi trivas så bra tillsammans, å ja.\nJa kräftan å ja', ja kräftan å ja',\nvi trivas i fröjd och gamman.\nDär ligger hon på ett fat mellan dill\noch lovar precis så mycket du vill\noch får man en iskall nubbe därtill,\nav glädje man faller samman.",
                    ""));
            songs.Add(new Song(
                    "Å detta brännvin",
                    "Melodi: I Apladalen i Värnamo",
                    "",
                    "Å detta brännvin som alltid jäklas\nför framåt natten man måste kräkas.\nFör kräftor har ju så hårda skal,\nde kan ju fastna i ens anal!",
                    ""));
        }

        if (type == SongType.Bakfylla)
        {

            /* BAKFYLLA */
            songs.Add(new Song(
                "Treo-Comp",
                "Melodi: Längtan till landet",
                "",
                "Morgonstund med smak av döda bävrar,\nfrukostmorgonen är över oss.\nHur vi stretar, hur vi alla vägrar,\nså går solen likt förbannat opp.\nSnart är dagen här med hemska plågor,\nhuvudvärk och ångest, elände, men\ndet finns faktiskt ett glas som dig kan rädda:\nTreo-Comp, vår frälsare och vän.",
                ""));
            songs.Add(new Song(
                    "Dränkta lucia",
                    "Melodi: Natten går tunga fjät",
                    "",
                    "Huvet slår kopparslag,\nögonen svider,\nmagen i obehag,\nnatten den lider.\nDå genom strupen går,\nhembränd en liten tår,\nvördat vare vårat brännvin,\nvördat vårt brännvin",
                    ""));
            songs.Add(new Song(
                    "Strömmar av whisky",
                    "Melodi: Drömmar av silver",
                    "",
                    "Strömmar av whisky, strömmar av gin.\nVaknar på morgon' full som ett svin.\nStiger ur sängen, faller omkull,\nsjutusan djävlar, vad jag är full.",
                    ""));
            songs.Add(new Song(
                    "Var var jag igår?",
                    "Melodi: Bei mir bist du schö",
                    "",
                    "||: Bär ner mig till sjön! :||\nJag känner att jag måste i.\nOch när du badat mig,\nså får du torka mig,\noch när du torkat mig,\nså vill jag i igen.\n||: Bär ner mig till sjön! :||\nJag känner att jag måste i.\n\n||: Var var jag igår? :||\nJag undrar var jag var igår.\nMitt huvud känns så tungt,\njag kan ej andas lugnt.\nHur har jag kommit hem?\nVem stoppa' mig i säng?\n||: Var var jag igår? :||\nJag undrar var jag var igår.\n\n||: Var var jag igår? :||\nJag undrar var jag var igår.\nEtt gäng med aspirin,\ndet gör mig pigg och fin.\nNu kan jag se igen,\njag hamnat i fel säng!\n||: Var var jag igår? :||\nJag undrar var jag var igår.",
                    ""));
            songs.Add(new Song(
                    "Mjölk, mjölk",
                    "Melodi: Trink, trink, brüderlein trink",
                    "",
                    "Mjölk, mjölk, vi vill ha mjölk.\nDet är en underbar dryck!\nMjölk, mjölk, vi vill ha mjölk.\nDet är vår senaste nyck.\nHämta din spann och mjölka din get,\nge mig en klunk utav det.\nSlut upp i kampen för helnykterhet.\nMjölk är det bästa vi vet!",
                    ""));
            songs.Add(new Song(
                    "Bakfyllesång",
                    "Melodi: Änglamark",
                    "",
                    "Huvudvärk, svettningar, darrningar och diarré.\nGe mig en isblåsa och en gul Jaffa.\nB-vitaminer, apelsinjuice och lite te.\nKan de bakfyllan måhända bortfösa.\nFesten var dålig, men nattsexan blev för bra:\nJansson's temptation och brännvinsturnering.\nBorta var jag då i går kväll men mest i dag.\nNo concentration, men mycket vomering.",
                    ""));
            songs.Add(new Song(
                    "Drömmar om sillis",
                    "Melodi: Drömmar av silver",
                    "",
                    "Drömmar om sillis, drömmar av gull,\ntag lilla nubben, snart är du full.\nMorgonen randas: tomglas, kapsyl.\nDrömmen blev vatten och två magnecyl.",
                    ""));
            songs.Add(new Song(
                    "När mitt rus har tagit slut",
                    "Melodi: I ett hus vid skogens slut",
                    "",
                    "När mitt rus har tagit slut\nsvullen tunga tittar ut.\nHjärtat skuttar fram så fort,\nvad är det jag gjort?\n\nHjälp ack, hjälp ack, hjälp du mig\nannars vänder magen sig.\nÅterställar'n kom nu in,\nin i munnen min.",
                    ""));
            songs.Add(new Song(
                    "Antisnapsvisa",
                    "Melodi: Sjösala vals",
                    "",
                    "Huvudet vi lyfter med ett stön ur vår säng,\ndiskmaskin i buken, kanoner i huvudet.\nTungan som en plyschsoffa och yrseln i sväng,\ni ångesten vi svettas, kom sjung din refräng.\n\nVarför finns det aldrig någon nykter karneval?\nO, låt oss somna om så vi slipper våra kval.\nMen se, så många supar vi redan kastat upp i sängen:\nRenat och Skåne, Svartvinbär och fager Bäsk!",
                    ""));
            songs.Add(new Song(
                    "Sämre och sämre",
                    "Melodi: Bättre och bättre, dag för dag",
                    "",
                    "Sämre och sämre da'n därpå.\nSäg mig, vad gjorde jag igår?\nMånga namn för hur man mår sen\nbåde bilmek, betongkeps och Ågren.\nTag, en\nakvavitamin\noch gå på för full maskin.\nAj, aj, aj, aj, aj, aj, aj\nmen jag mår sämre och sämre da'n därpå!",
                    ""));
            songs.Add(new Song(
                    "Vit vecka",
                    "Melodi: White Christmas",
                    "",
                    "Jag drömmer om en vit vecka.\nSju dagar utan alkohol. \nTänk att bara skåla \ni juice och cola \noch sedan minnas allt man gjort.\n\nJag drömmer om en vit vecka, \ndet finns en gräns för vad jag tål. \nJag vill inte ha mera sprit \nså låt nästa vecka vara vit.",
                    ""));
            songs.Add(new Song(
                    "Minnet",
                    "Melodi: Memory",
                    "Text: Bosse Österberg",
                    "Minne, jag har tappat mitt minne.\nÄr jag svensk eller finne?\nKommer inte ihåg.\nInne, är jag ut' eller inne?\nJag har luckor i minne',\nsån' där små alkohol.\nMen besinn' er,\nman tätar med det brännvin man får,\nfastän minnet och helan går.",
                    "Skall sjungas på finlandssvenska."));
            songs.Add(new Song(
                    "Hjärnan som klister",
                    "Melodi: Lili Marlene",
                    "",
                    "Hjärnan som klister,\nhanden skakar lätt.\nLevern är som ister,\nstor och vit av fett.\nMagen den känns som en vulkan,\nmitt öga lyser som Aldebaran.\n||: Ta hit ett glas, för fan. :||",
                    ""));
            songs.Add(new Song(
                    "Krognota",
                    "Melodi: Lysmaskidyll",
                    "",
                    "Tag dig en sup fast din plånbok bantar.\nRäkningen här går på feta slantar:\n\nSnaps               400:69\nPåfyllda supar      22:10\nGroggvirke          1003:19\nMera utbångat       (fast utan kvitton)\n\nAvrundat            2502\nNågonting att tänka på.",
                    ""));
            songs.Add(new Song(
                    "Botvisa",
                    "Melodi: I fjol så gick jag med herrarna i hagen",
                    "",
                    "Igår så drack jag punsch hela dagen,\naj, aj, punsch hela dagen, ja, punsch hela dagen.\nIdag har jag huvudvärk och ont uti magen,\naj, aj, ont uti magen, ja, ont uti magen.\n\nIgår var jag glad som en kalv ut på ängen,\naj, aj, kalv ut på ängen, ja, kalv ut på ängen.\nIdag har jag svårt att komma ur sängen,\naj, aj, komma ur sängen, ja, komma ur sängen.\n\nMen nu ska jag ta mig en ny liten pärla,\naj, aj, ny liten pärla, ja, ny liten pärla.\nDet lättar humöret, man blir fri som en ärla,\naj, aj, fri som ärla, ja, fri som en ärla.",
                    ""));
            songs.Add(new Song(
                    "Kopparslagaren",
                    "Melodi: En sockerbagare här bor i staden",
                    "",
                    "Små kopparslagare här bor i staden,\nde är ett otyg för varje glad en.\nDe plågar stora, de plågar små,\nde plågar många - mest dan därpå.\n\nPå förmiddagen de väcker opp en\nmed dunderslag uti huvudknoppen.\nSin dag de börjar med friskt humör,\noch till sin verkstad de huvet gör.\n\nMen hettan ökar inunder pannan\nman söker släcka med vattenkannan.\nMan dricker mjölk och tar magnecyl\nmen ändock glöder var molekyl\n\nDock, kopparslagare kan man nog slippa\nom man går nykter ifrån var hippa,\nom man förblir vad man är helt visst,\nen pigg och skötsam absolutist.\n\nMen vi, som lärt utav livet mera,\nvet andra medel att den parera.\nVi har en visdom - oändligt djup;\nvi stiger opp och tar oss en sup.",
                    ""));
            songs.Add(new Song(
                    "Buller och trätor",
                    "Melodi: Ja, må han leva",
                    "",
                    "Buller och trätor och slagsmål och fasor,\nstölder och rån, även mordbrand och död.\nDrunkning, förfrysning och armod och trasor,\nsjukdom och svaghet, förgiftning och nöd.\n\nMinskning av lust och av arbetsförmåga,\nslapphet i vilja, i kraft och moral.\nÄrftliga anlag till sjukdom och plåga,\nlidelse, olycka, tårar, skandal.\n\nLaster och slöhet och uttröttat hjärta,\ngrymhet och piskslag och missbrukad makt.\nOndska, förbannelse, undergång, smärta,\nfattigdom, elände, skam och förakt.\n\nHatet och svälten samt ängslig förbidan,\nfängelse, yrsel och vansinnig blick.\nSprängning av hemmet samt sorger och kvidan,\nsäg vill du pröva allt detta så drick.",
                    ""));
            songs.Add(new Song(
                    "Full just idag",
                    "Melodi: Rosen (refrängen)",
                    "",
                    "Full just idag, men imorgon ska jag\nbli nykterist för jag mår inte bra.\nDen sista jag tog fick mig att få nog,\nfick mig att spy i min grannes sko!",
                    ""));
        }

        if (type == SongType.Nördigt)
        {

            /* NÖRDIGT */
            songs.Add(new Song(
                "Om Emacs",
                "Melodi: Kovan kommer, kovan går",
                "Text: Ingemar Ragnemalm",
                "Emacs är en stor koloss.\nTugga på, tugga på.\nVerkar aldrig komma loss.\nTugga på, tugga på.\nFör att flytta på ett tecken\ngår två meg i garbage-säcken.\nNer i skärmens undre rand\nstår: garbage collecting, done!\n\nVäntar på'n till min pension.\nTugga på, tugga på.\nEmacs gör en Sparcstation\nTugga på, tugga på.\nsnabb som en ABC-80.\nHögprestanda blir så smått i\nEmacs, den ser säkert till\ningen dödtid blir förspilld!\n\nEmacs skriven är i Lisp.\nTugga på, tugga på.\nInget rimmar alls på Lisp.\nTugga på, tugga på.\nOm du in i kärnan trevar\nfinn en gnu som motorn vevar.\nDen drar Emacs runt för hand!\nKlart att det går trögt ibland!",
                ""));
            songs.Add(new Song(
                    "Länka lilla dator där",
                    "Melodi: Blinka lilla stjärna",
                    "",
                    "Länka lilla dator där,\nhur jag undrar hur du är.\nStändigt frestar du mitt mod,\nmed en massa fel i kod.\nBlinka lilla dator kär, \nvad jag undrar hur du gör.\n\nNär den sköna sol blitt släckt,\nstrax du startas upp så käckt.\nBörjar klar din stilla gång,\nglimmar, glimmar natten lång.\nLänka lilla dator kär,\njag undrar vad klockan är.",
                    ""));
            songs.Add(new Song(
                    "Système International",
                    "Melodi: Studentsången",
                    "",
                    "W kg m Wb s\nΩ m T A rad\nCd S N s\nΩ A m Lx dB\n°C W/m²\nJ/kg H V C\nkg/m³ mol\nm/s²\nm/s²\nF!",
                    ""));
            songs.Add(new Song(
                    "Bring back my dump tape to me",
                    "Melodi: My Bonnie",
                    "",
                    "His first day our new operator\nknew not what root's powers might be.\nOne 'rm -rf /' later... ('r m dash r f slash')\nOh, bring back my dump tape to me!\n\nBring back, bring back,\noh, bring back that dump tape to me, to me.\nBring back, bring back,\noh, bring back our last DAT.",
                    ""));
            songs.Add(new Song(
                    "Yesterday",
                    "",
                    "",
                    "Yesterday,\nall those backups seemed a waste of pay.\nNow my database has gone away.\nOh I believe in yesterday.\n\nSuddenly,\nthere's not half the files there used to be,\nand there's a milestone hanging over me.\nThe system crashed so suddenly.\n\nI pushed something wrong,\nwhat it was I could not say.\n\nNow all my data's gone\nand I long for yesterday-ay-ay-ay.\n\nYesterday,\nthe need for back-ups seemed so far away.\nI knew my data was all here to stay,\nnow I believe in yesterday.",
                    ""));
            songs.Add(new Song(
                    "Programmer's Drinking Song",
                    "",
                    "",
                    "99 little bugs in the code,\n99 bugs in the code.\nFix one bug, compile it again,\n100 little bugs in the code.",
                    "Repeat until (bugs == 0)."));

            songs.Add(new Song(
                    "Mors lilla dator",
                    "Melodi: Mors lille Olle",
                    "",
                    "Mors lilla dator åt skogen gick,\nmitt i programmet sade det klick.\nSvart bidde skärmen och minnet försvann,\nden informationen kan ingen få fram.\n\nBrummeli-brum, vad brummar där?\nDet sprakar och gnistrar, ett jordfel det är!\nBlixtar blå ifrån burken det slå,\nsynd att jag här nu ensam får stå.\n\nHyscheli-hysch, vad prasslar här?\nFram väller pappret ur printern där!\nDen har fått nippran av tecken så små,\njag tror att jag snart hemåt skall gå.",
                    ""));
            songs.Add(new Song(
                    "The BASIC Song",
                    "Melodi: Mors lille Olle",
                    "",
                    "10 LET oss nu fatta i våra glas\n20 INPUT en klunk utav det som där has\n30 IF du fått nog THEN till 50 min vän\n40 ELSE GOTO-baka till l0 igen\n50 END",
                    ""));
            songs.Add(new Song(
                    "Hackerns trosbekännelse",
                    "",
                    "",
                    "Fader Dator, som är i Salen,\nhelgad vare Din skärm,\ntillkomme Ditt tangentbord,\nske Din vilja, så som i minnet,\nså ock på nätet.\nVår dagliga utskrift giv oss idag\noch förlåt oss våra misstag\ntrots att vi ej förlåta\ndem som skyldiga äro.\nLåt oss icke behöva vänta\noch fräls oss ifrån dumpar.\nTy Salen är din\noch Makten hos Handledaren \ni Evighet.\n\nUNIX.",
                    ""));
            songs.Add(new Song(
                    "Write in C",
                    "Melodi: Let it be",
                    "",
                    "When I find my code in tons of trouble,\nfriends and colleagues come to me,\nspeaking words of wisdom:\n'Write in C'.\n\nAs the deadline fast approaches,\nand bugs are all that I can see,\nsomewhere, someone whispers:\n'Write in C'.\n\nWrite in C, write in C,\nwrite in C, oh, write in C.\nLOGO's dead and buried,\nwrite in C.\n\nI used to write a lot of FORTRAN,\nfor science it worked flawlessly.\ntry using it for graphics!\nWrite in C.\n\nIf you've just spent nearly 30 hours\ndebugging some assembly,\nsoon you will be glad to\nwrite in C.\n\nWrite in C, write in C,\nwrite in C, yeah, write in C.\nOnly wimps use BASIC,\nwrite in C.\n\nWrite in C, write in C \nwrite in C, oh, write in C.\nPascal won't quite cut it,\nwrite in C.\n\nWrite in C, write in C,\nwrite in C, yeah, write in C.\nDon't even mention COBOL,\nwrite in C.\n\nAnd when the screen is fuzzy,\nAnd the editor is bugging me.\nI'm sick of ones and zeroes,\nwrite in C.\n\nA thousand people swear that T.P.\nSeven is the one for me.\nI hate the word PROCEDURE,\nwrite in C.\n\nWrite in C, write in C,\nWrite in C, yeah, write in C.\nPL1 is 80's,\nwrite in C.\n\nWrite in C, write in C,\nWrite in C, yeah, write in C.\nThe government loves ADA,\nwrite in C.",
                    ""));
        }

        if (type == SongType.Odödliga)
        {

            /* ODÖDLIGA */
            songs.Add(new Song(
                "Fredmans epistel N:o 81",
                "Melodi: Carl Michael Bellman",
                "Text: Carl Michael Bellman",
                "Märk hur' vår skugga, märk Movitz Mon Frere!\nInnom et mörker sig slutar,\nHur Guld och Purpur i Skåfveln, den där,\nByts til grus och klutar.\nVinkar Charon från sin brusande älf,\nOch tre gånger sen Dödgräfvaren sjelf,\nMer du din drufva ej kryster.\nDärföre Movitz kom hjelp mig och hvälf\nGrafsten öfver vår Syster.\n\nAch längtansvärda och bortskymda skjul,\nUnder de susande grenar,\nDär Tid och Döden en skönhet och ful\nTil et stoft förenar!\nTil dig aldrig Afund sökt någon stig,\nLyckan, eljest uti flygten så vig,\nAldrig kring Grifterna ilar.\nOvän där väpnad, hvad synes väl dig?\nBryter fromt sina pilar.\n\nLillklockan klämtar til Storklockans dön,\nLöfvad står Cantorn i porten;\nOch vid de skrålande Gåssarnas bön,\nHelgar denna orten.\nVägen opp til Templets griftprydda stad\nTrampas mellan Rosors gulnade blad,\nMultnade Plankor och Bårar;\nTil dess den långa och svartklädda rad,\nDjupt sig bugar med tårar.\n\nSå gick til hvila, från Slagsmål och Bal,\nGrälmakar Löfberg, din maka;\nDär, dit åt gräset långhalsig och smal,\nDu än glor tilbaka.\nHon från Danto bommen skildes i dag,\nOch med Hänne alla lustiga lag;\nHvem skall nu Flaskan befalla.\nTorstig var hon och uttorstig är jag;\nVi ä torstiga alla.",
                "Til Grälmakar Löfberg i Sterbhuset vid Danto bommen, diktad vid Grafven. Dedicerad til Doctor BLAD. Sannolikt skriven 1790 eller möjligen något år tidigare."));
            songs.Add(new Song(
                    "Fredmans sång N:o 64",
                    "Melodi: Carl Michael Bellman",
                    "Text: Carl Michael Bellman",
                    "Fjäriln vingad syns på Haga,\nMellan dimmors frost och dun,\nSig sitt gröna skjul tillaga,\nOch i blomman, sin paulun;\nMinsta kräk i kärr och syra,\nNyss af Solens värma väckt,\nTil en ny högtidlig yra\nEldas vid Zephirens flägt.\n\nHaga, i ditt sköte röjes\nGräsets brodd och gula plan;\nStolt i dina ränlar höjes\nGungande den hvita Svan;\nLängst ur skogens glesa kamrar\nHöras täta återskall,\nÄn från den graniten hamrar,\nÄn från yx i björk och tall.\n\nSe Brunsvikens små Najader\nHöja sina gyldne horn,\nOch de frusande cascader\nSprutas öfver Solna torn;\nUnder skygd af hvälfda stammar,\nPå den väg man städad ser,\nFålen yfs och hjulet dammar,\nBonden mildt åt Haga ler.\n\nHvad Gudomlig lust at röna\nInnom en så ljuflig Park,\nDå man hälsad af sin Sköna,\nÖgnas af en mild Monark!\nHvarje blick hans öga skickar,\nLockar tacksamhetens tår;\nRörd och tjust af dessa blickar,\nSjelf den trumpne glädtig går.",
                    "Dediceras til Herr Capitainen KJERSTEIN. Skriven 1790 eller 1791."));
            songs.Add(new Song(
                    "Fredmans sång N:o 21",
                    "",
                    "Text: Carl Michael Bellman",
                    "Så lunka vi så småningom\nFrån Bacchi buller och tumult,\nNär döden ropar: Granne kom,\nDitt timglas är nu fullt.\nDu Gubbe fäll din krycka ner,\nOch du, du Yngling, lyd min lag,\nDen skönsta Nymph som åt dig ler\nInunder armen tag.\nTycker du at grafven är för djup,\nNå välan så tag dig då en sup,\nTag dig sen dito en, dito två, dito tre,\nSå dör du nöjdare.\n\nDu vid din remmare och präss,\nRödbrusig och med hatt på sned,\nSnart skrider fram din likprocess\nI några svarta led;\nOch du som pratar där så stort,\nMed band och stjernor på din rock,\nRe'n snickarn kistan färdig gjort,\nOch hyflar på des lock.\nTycker du...\n\nMen du som med en trumpen min,\nBland riglar, galler, järn och lås,\nDig hvilar på ditt penningskrin,\nInnom din stängda bås;\nOch du som svartsjuk slår i kras\nButeljer, speglar och pocal;\nBjud nu god natt, drick ut dit glas,\nOch helsa din rival;\nTycker du...\n\nOch du som under titlars klang\nDin tiggarstaf förgylt hvart år,\nSom knappast har, med all din rang,\nEn skilling til din bår;\nOch du som ilsken, feg och lat,\nFördömmer vaggan som dig hvälft,\nOch ändå dagligt är placat\nTil glasets sista hälft;\nTycker du...\n\nDu som vid Martis fältbasun\nI blodig skjorta sträckt ditt steg;\nOch du som tumlar i paulun,\nI Chloris armar feg;\nOch du som med din gyldne bok\nVid templets genljud reser dig,\nSom rister hufvud lärd och klok,\nOch för mot afgrund krig;\nTycker du...\n\nMen du som med en ärlig min\nPlär dina vänner häda jämt,\nOch dem förtalar vid dit vin,\nOch det liksom på skämt;\nOch du som ej försvarar dem,\nFastän ur deras flaskor du,\nDu väl kan slicka dina fem,\nHvad svarar du väl nu?\nTycker du...\n\nMen du som til din återfärd,\nIfrån det du til bordet gick,\nEj klingat för din raska värd,\nFastän han ropar: Drick!\nDrif sådan gäst från mat och vin,\nKör honom med sitt anhang ut,\nOch sen med en ovänlig min,\nRyck remmarn ur hans trut.\nTycker du...\n\nSäg är du nöjd? min granne säg,\nSå prisa värden nu til slut;\nOm vi ha en och samma väg,\nSå följoms åt; drick ut.\nMen först med vinet rödt och hvitt\nFör vår Värdinna bugom oss,\nOch halkom sen i grafven fritt,\nVid aftonstjernans bloss.\nTycker du...",
                    "Måltids sång. Skriven mellan jul och nyår 1787 medan Bellman sörjde sonen Elis som gått bort ett par månader tidigare."));
            songs.Add(new Song(
                    "Fredmans sång N:o 35",
                    "Melodi: Carl Michael Bellman",
                    "Text: Carl Michael Bellman",
                    "||: Gubben Noach, Gubben Noach\nVar en hedersman, :||\nNär han gick ur arken\nPlantera han på marken\nMycket vin, ja mycket vin, ja\nDetta gjorde han.\n\n||: Noach rodde, Noach rodde\nUr sin gamla ark, :||\nKöpte sig buteljer,\nSådana man sälljer,\nFör at dricka, för at dricka\nPå vår nya park.\n\n||: Han väl visste, han väl visste\nAt en mänska var :||\nTorstig af naturen\nSom de andra djuren,\nDärför han ock, därför han ock\nVin planterat har.\n\n||: Gumman Noach, Gumman Noach\nVar en heders fru; :||\nHon gaf man sin dricka;\nFick jag sådan flicka,\nGifte jag mig, gifte jag mig\nJust på stunden nu.\n\n||: Aldrig sad' hon, aldrig sad' hon\nKära far nå nå; :||\nSätt ifrån dig kruset;\nNej det ena ruset\nPå det andra, på det andra\nLät hon gubben få.\n\n||: Gubben Noach, Gubben Noach\nBrukte egna hår, :||\nPipskägg, hakan trinder\nRosenröda kinder,\nDrack i botten, drack i botten.\nHurra och gutår!\n\n||: Då var lustigt, då var lustigt\nPå vår gröna jord; :||\nMan fick väl til bästa,\nIngen torstig nästa\nSatt och blängde, satt och blängde\nVid et dukadt bord.\n\n||: Inga skålar, inga skålar\nGjorde då besvär, :||\nDå var ej den läran:\nJag skal ha den äran;\nNej i botten, nej i botten\nDrack man ur så här.",
                    "1 Mos 9:20-21: 'Och Noah begynte til och wardt en åkerman, och planterade en wingård. Och tå han drack af winet, wardt han drucken, och låg oskyld i sine hyddo'."));
            songs.Add(new Song(
                    "Bort alt hvad oro gör",
                    "",
                    "Text: Carl Michael Bellman",
                    "Bort alt hvad oro gör, \nbort alt hvad hjertat qväljer!\nBäst at man väljer\nBland desse Bouteiller\nSin mag-liqueur.\nGranne! gör du just som jag gör,\nVet denna oljan ger humeur.\nHvad det var läckert!\nHvad var det? Renskt Bläckert?\nOui Monseigneur.\n\nBort alt hvad oro gör,\nAlt är ju stoft och aska,\nLåt oss bli raska,\nOch tömma vår flaska\nBland Bröderna.\nGranne! gör du just som jag gör,\nVet denna oljan ger humeur.\nHvad det var mägtigt!\nHvad var det? ... Jo präktigt,\nMallaga - ja.",
                    "Sång nr 17 ur Bacchi Tempel."));
        }
        return songs;
    }

	public static List<Song> GetEkivokaSongs()
    {
        List<Song> songs = new List<Song>();
        songs.Add(new Song(
                "Porros visa – pojkarnas",
                "Melodi: Portos visa",
                "",
                "Jag vill börja schlicka,\n" +
                "var fan är min flicka,\n" +
                "vem i helvete stal min modell?\n" +
                "Skall kättjan mig tvinga,\n" +
                "min höger börja svinga?\n" +
                "Nej, för fan, bara blunda och svälj!\n" +
                "Vilken smörja! Får jag spörja:\n" +
                "\"Vem för fan tror att jag är en Älg?\"\n" +
                "\n" +
                "Till Thailand vi rider \n" +
                "och sedan vad det lider\n" +
                "träffar vi välan på någon club.\n" +
                "Och där skall vi fläska,\n" +
                "blott stöta i det bästa.\n" +
                "Uti alla med hål i,\n" +
                "vi tänker stå hårt i,\n" +
                "för att sätta på rubb och stubb!",
                ""));
        songs.Add(new Song(
                "Porros visa – flickornas",
                "Melodi: Portos visa",
                "",
                "Jag vill runka pille,\n" +
                "va' fan är min kille,\n" +
                "vem i helvete stal min massagestav.\n" +
                "Skall törsten mig tvinga,\n" +
                "en balle börja svinga?\n" +
                "Nej för fan bara runka och svälj!\n" +
                "Vilken smörja! Får jag spörja:\n" +
                "”Vem för fan tror att jag är en dum brud?”\n" +
                "\n" +
                "Till Grekland vi rider\n" +
                "och sedan vad det lider\n" +
                "träffar vi välan på någon hunk.\n" +
                "Och han ska vi rida,\n" +
                "tills det börjar svida.\n" +
                "Då tackar vi kuken,\n" +
                "och tar sen till kuken,\n" +
                "för att sätta på rubb och stubb!",
                ""));
        songs.Add(new Song(
                "Det satt en mus",
                "Melodi: När månen vandrar på fästet blå",
                "",
                "Det satt en mus på en klyvarbom\n" +
                "och torr i fittan var kräket,\n" +
                "och tungan hängde från skepparns gom,\n" +
                "mot hans styvnande veke.\n" +
                "Jag vill ha kuk hördes musen kvida,\n" +
                "och skepparn svarte: \"Fläk upp din slida,\n" +
                "ska du få fläns, pumpa läns!\"",
                ""));
        songs.Add(new Song(
                "Drömmar om plåt",
                "Melodi: Drömmar av ",
                "",
                "Drömmar om silver, drömmar om plåt, \n" +
                "vakna nu älskling, för nu är jag kåt. \n" +
                "Lägg dig på sängen, slappna nu av, \n" +
                "sära på bena för här kommer jag!",
                ""));
        songs.Add(new Song(
                "Dinah",
                "",
                "",
                "A rich girl has a limousine, \n" +
                "a poor girl has a truck. \n" +
                "The only time that Dinah rides \n" +
                "is when she has a fuck.  \n" +
                "Dinah, Dinah, show us your legs,\n" +
                "show us your legs, show us your legs. \n" +
                "Dinah, Dinah, show us your legs \n" +
                "a yard above your knee.   \n" +
                "\n" +
                "A rich girl has a ring of gold,\n" +
                "a poor girl one of brass;\n" +
                "but the only ring that Dinah has\n" +
                "is the one around her arse.\n" +
                "Dinah, Dinah …\n" +
                "A rich girl uses vaseline,\n" +
                "a poor girl uses lard;\n" +
                "but Dinah uses axle grease\n" +
                "because her cunt's so hard.\n" +
                "Dinah, Dinah …\n" +
                "A rich girl uses sanitary towels\n" +
                "a poor girl uses sheets;\n" +
                "but Dinah uses fuck all - see \n" +
                "the trail along the streets.\n" +
                "Dinah, Dinah …",
                ""));
        songs.Add(new Song(
                "Bastuvisan",
                "Melodi: Vårat gäng ",
                "",
                "Här i våran bastu känns\n" +
                "torra värmen, som ej bränns,\n" +
                "som en smekning, ljuv och skön.\n" +
                "Bed din bastubön.\n" +
                "Gno med skrubben. - Raka stubben\n" +
                "av din haka. - Sen skall smaka\n" +
                "när du beger - dig tillbaka\n" +
                "in i stugan till din tjej.\n" +
                "\n" +
                "Ger hon rakpussen till dej.\n" +
                "Kläd dig och res därpå hem\n" +
                "ren och blank, och lagom slank\n" +
                "och kom snart igen.",
                ""));
        songs.Add(new Song(
                "Mossbelupen",
                "Melodi: Imbelupet",
                "",
                "Mossbelupen fitta under skrynklig buk.\n" +
                "Den ser ut att rymma minst en tolvtumskuk.\n" +
                "I dess kanter hänga slamsor, gonorré och annan skit,\n" +
                "och i raggen kilar baggen hit och dit.\n" +
                "\n" +
                "Kuken sprutar, Ida kvider när det går.\n" +
                "Satsen rinner nerför Idas feta lår.\n" +
                "Men därinne på en pinne, hänger Idas mödom kvar,\n" +
                "den ska hänga där på tork i fjorton dar.",
                ""));
        songs.Add(new Song(
                "Bamse",
                "",
                "",
                "Bamse knullar lille Skutt i baken\n" +
                "Svansen kittlar skönt när man är naken.\n" +
                "Skalman runkar, Farmor kokar honung,\n" +
                "så att Bamse kan få stånd igen.\n" +
                "\n" +
                "Gangbang uti alla hål,\n" +
                "är mer än Mickelina tål,\n" +
                "men det är svårt att säga stopp\n" +
                "med munnen full av snopp.\n" +
                "\n" +
                "Krösus köper kärleken på gatan.\n" +
                "Sedan får han ont av bara satan.\n" +
                "Går till doktorn, doktorn bara skrattar:\n" +
                "”Du kan aldrig mer få stånd igen.”\n" +
                "\n" +
                "För om man inte kan få stånd\n" +
                "Så får man ej en enda gång\n" +
                "Få pippa nå’n med kuken lång\n" +
                "och det som är så skönt\n" +
                "\n" +
                "Skalman, Skalman, homosexualman\n" +
                "Bamse, tramse knullar med sin fru.\n" +
                "Lille skutt har fullt upp i sin farmor.\n" +
                "Sjörövarna bögar på sitt skepp.",
                ""));
        songs.Add(new Song(
                "Blottarkärlek",
                "Melodi: Flottarkärlek",
                "",
                "Jag var ung en gång för länge se’n\n" +
                "en blottare på stan\n" +
                "och dessutom var jag traktens nymfoman.\n" +
                "Varje flicka varje pojke \n" +
                "var för mig ett sexobjekt.\n" +
                "Även hästar, kor och grisar jag betäckt.\n" +
                "Haderian hadera, doppa löken varje da’.\n" +
                "Om man dricker råa ägg så går det bra.\n" +
                "\n" +
                "Jag ska gnida på min pillesnopp\n" +
                "så länge jag förmår.\n" +
                "Jag ska gnida fram och åter tills det går.\n" +
                "Och när sädesvätskan sprutar\n" +
                "sjunger jag en liten sång\n" +
                "och jag drömmer om en flicka het och trång.\n" +
                "Haderian haderej, sätta på varenda tjej.\n" +
                "Om du ringer mig så sätter jag på dig.",
                ""));
        songs.Add(new Song(
                "Åh Carola",
                "Melodi: Någonstans i Sverige ",
                "",
                "Hennes ben är för korta, \n" +
                "hennes kjol är för lång.\n" +
                "Hennes bröst är för stora, \n" +
                "hennes blus är för trång.\n" +
                "Men det gör detsamma, \n" +
                "för hon är vår idol. \n" +
                "Åh, Carola Häggkvist.",
                ""));
        songs.Add(new Song(
                "Bluff och spark",
                "Melodi: Lingonben",
                "",
                "Bluff och Spark och Tork och Kvark\n" +
                "voro sex små dvärgar.\n" +
                "En var ful och en var kåt\n" +
                "och en han hade herpes.\n" +
                "\"Hej!\", sa Tork till lille Kvark,\n" +
                "\"Känner du hur jag kör i dig?\"\n" +
                "Han som har varit i Patpong.\n" +
                "Ja, det gjorde Sixten.\n" +
                "Ser du på hans lilla sak,\n" +
                "där han pippar på sitt tak.\n" +
                "Tripp och trapp och drypan.\n" +
                "Se hans feta faster.\n" +
                "\n" +
                "Tomtefar med årets rus,\n" +
                "sitter som ett päron.\n" +
                "Han har ingen egen mus\n" +
                "allt i sitt stora harem.\n" +
                "Söt och blöt är skogens fé,\n" +
                "trollen är bjudna dit för kel.\n" +
                "Det lilla trollet pax för det.\n" +
                "Nu ska mormor runka.\n" +
                "Bryna och nuppa natten lång,\n" +
                "prinsen är här med jättefjong!\n" +
                "Hipp och hopp och just det.\n" +
                "Hästen går på valium.\n" +
                "\n" +
                "\n" +
                "Stora slottet Irumpandipp,\n" +
                "ligger Bortom Farsta.\n" +
                "Di får ingen komma in,\n" +
                "som inte använt vaselin.\n" +
                "Försupet troll och sockersnopp,\n" +
                "nu ska vi pulla häxan våt.\n" +
                "Vill du mig ta, så ta mig då,\n" +
                "i mitt lilla tryne.\n" +
                "Kungen är full av konkelbär.\n" +
                "Silvia sitter här och svär.\n" +
                "Viktoria är full av sperma.\n" +
                "Hur ska Lillan orka?",
                ""));
        songs.Add(new Song(
                "Bondvisa",
                "Melodi: När månen vandrar ",
                "",
                "Och drängen han satt i vån,\n" +
                "i kammaren, i kammaren.\n" +
                "Han banka kuken sin gul och blå.\n" +
                "Med hammaren, med hammaren.\n" +
                "Jag ska lära dig att bli lång,\n" +
                "först med hammare och sen med tång.\n" +
                "Din djävel, Din djävel.\n" +
                "\n" +
                "Och pigan hon satt i vån,\n" +
                "vid väven, vid väven.\n" +
                "Hon banka fittan sin gul och blå,\n" +
                "med näven, med näven.\n" +
                "Jag ska lära dig sluka ballen,\n" +
                "först med hammare och sen med pallen,\n" +
                "din djävel, din djävel.",
                ""));
        songs.Add(new Song(
                "Allmänna obdusången",
                "Melodi: Askungens klänning",
                "",
                "Nekrofiler är vi båda och vi sitter här och knådar.\n" +
                "Vi tar ju dem i häcken och slänger den i bäcken.\n" +
                "Vi styckar alla liken och slänger dem i diken.\n" +
                "Att allmänpraktisera och att liken obducera\n" +
                "får oss båda att spontant ejakulera.\n" +
                "\n" +
                "Vi är båda pederaster men vi har nog inga laster.\n" +
                "Vi vill inte klappa slinkor, blott skära barnaskinkor.\n" +
                "Vi är ej i grottekvarnen men väl i gossebarnen.\n" +
                "Vi lockar dem med snask och sen så tar vi fram vår task\n" +
                "och särar de ej upp sig får de dask.\n" +
                "\n" +
                "Vi har inga perversioner. Vi gör det helt normalt.\n" +
                "Enligt gamla traditioner. Så tar vi dem analt.\n" +
                "Tänk om den blir en pumpa långt upp uti ett gossebarn.\n" +
                "Då jävlar blir det trångt, ja då har det gått för långt,\n" +
                "å ungjäveln sprängs sedan mitt itu.\n" +
                "\n" +
                "Vi pippar gärna rådjur och ett och annat smådjur.\n" +
                "Vi tejpar de små liven och smörjer med saliven.\n" +
                "En boa sitter gott om man har smort honom med flott,\n" +
                "med olja, smör och ister men inte med nått klister\n" +
                "undviker man att alla hinnor brister.",
                ""));
        songs.Add(new Song(
                "Calypso pervers",
                "Melodi: En glad calypso om våren",
                "",
                "Ack den som vore i dina kläder.\n" +
                "Jag blir så vansinnigt kåt på läder.\n" +
                "För att ej tala om gummi se’n\n" +
                "som slinker följsamt längs bara ben.\n" +
                "Jag vill bli inlåst med dubbla reglar.\n" +
                "I mörkret sitter jag sen och dreglar.\n" +
                "Och väntar på en stöddig vakt\n" +
                "med piskan lär mig vem som har makt.\n" +
                "Tralalalalalala, tralalalalalala...\n" +
                "\n" +
                "Jag drömmer om piskor, tömmar.\n" +
                "Och vispad grädde i strida strömmar\n" +
                "som smetas in på min bara kropp\n" +
                "när grisar rider mig i galopp.\n" +
                "Min döda amma ifrån Castilien\n" +
                "har plötsligt fått mig att bli nekrofil igen.\n" +
                "Men allra bäst är en kärleksstund\n" +
                "framför brasan med mormors hund!\n" +
                "Tralalalalalala, tralalalalalala...",
                ""));
        songs.Add(new Song(
                "Sillesalteriet",
                "Melodi: Skörda linet idag ",
                "",
                "Förr jobba´ vi i sillesalteri\n" +
                "men va finge vi för detta?\n" +
                "Jo, trasiga böxer, loppbetna lår\n" +
                "å inte ett strå på fetta.",
                ""));
        songs.Add(new Song(
                "Det var en gång en flicka",
                "Melodi: Jag gick mig ut en afton",
                "",
                "Det var en gång en flicka som red uppå ett svin\n" +
                "och flickan hon var naken men glad var hennes min.\n" +
                "Den borsten, den borsten\n" +
                "den river gott som brännevin.\n" +
                "Den borsten, den borsten\n" +
                "på ryggen på ett svin.\n" +
                "\n" +
                "Det var en gång en flicka som satt uppå en katt\n" +
                "och flickan hon var naken och glatt var hennes skratt.\n" +
                "Den svansen, den svansen\n" +
                "den visste var den satt, satt, satt.\n" +
                "Den svansen, den svansen\n" +
                "i ändan på en katt.\n" +
                "\n" +
                "Det var en gång en pojke som red på en spargris\n" +
                "och pojken han var naken på alla sätt och vis.\n" +
                "Den grisen, den grisen\n" +
                "den blir då aldrig full, full, full.\n" +
                "Den grisen, den grisen den blir då aldrig full.\n" +
                "\n" +
                "Det var en gång en flicka som red på en kastrull\n" +
                "och flickan hon var naken och tjockt var hennes hull.\n" +
                "Kastrullen, kastrullen\n" +
                "den känns ju som ett knull, knull, knull.\n" +
                "Kastrullen, kastrullen den känns ju som ett knull.\n" +
                "\n" +
                "\n" +
                "Det var en gång en pojke som tände på en tjej\n" +
                "och tjejen hon var villig så han tog fram sin grej.\n" +
                "Han fumla, han fumla men hitta aldrig in, in, in.\n" +
                "Han fumla, han fumla men hitta aldrig in.\n" +
                "\n" +
                "Det var en gång en flicka som gled uppå en ål\n" +
                "och flickan hon var naken och glatt var hennes vrål.\n" +
                "Den ålen, den ålen\n" +
                "den känns ju som en stång av stål.\n" +
                "Den ålen, den ålen\n" +
                "den känns ju som en... skål.\n" +
                "\n" +
                "Det var en gång en flicka som red uppå en älg.\n" +
                "Svälj!",
                ""));
        songs.Add(new Song(
                "Fido",
                "Melodi: Flottarkärlek ",
                "",
                "Har du sett en? Har du sett den?\n" +
                "Har du haft den i din mun?\n" +
                "Har du sett den? Har du haft den i din mun?\n" +
                "Har du kallat den för Fido?\n" +
                "Har du haft den i din mun?\n" +
                "Har du sett den? Har du haft den i din mun? \n" +
                "\n" +
                "Jag har sett den. Jag har sett den.\n" +
                "Jag har haft den i min mun.\n" +
                "Jag har sett den. Jag har haft den i min mun.\n" +
                "Jag har kallat den för Fido.\n" +
                "Jag har haft den i min mun.\n" +
                "Jag har sett den. Jag har haft den i min mun.",
                ""));
        songs.Add(new Song(
                "En flicka ung och fager",
                "Melodi: Gällivarevisa",
                "",
                "En flicka ung och fager, en gosse stor och stark\n" +
                "omfamnade varandra uti en lummig park.\n" +
                "Men bäst de båda njöto, så kom där en polis,\n" +
                "han vakna ur sin slummer utav en jubelfis.\n" +
                "\n" +
                "Han störta in i snåret, får fatt i gossens ben,\n" +
                "drar honom ut ur hålet och för till finkan sen.\n" +
                "Där fick han sova av sig sitt sköna kärleksrus,\n" +
                "men kanske flickan sitter ännu på Tavasthus.\n" +
                "\n" +
                "Men gossen svor att hämnas, han tänkte ut en plan.\n" +
                "Som skulle drabba alla, båd’ hög och låg i stan.\n" +
                "Han kokade en soppa på kuttan av ett bi\n" +
                "och lade femton tuppkukar och stånkanpulver i.\n" +
                "\n" +
                "I stadens alla brunnar han hällde sin mixtur,\n" +
                "och snart så märktes verkan på människor och djur.\n" +
                "På varje gammal kärring, på varje gammal märr,\n" +
                "stod kuttan våt och slaskig och alltid uppå spärr.\n" +
                "\n" +
                "Det knullades på gator, det knullades i hus,\n" +
                "och horor blevo rika och priset steg på ljus.\n" +
                "Prostinnan satt i trappan ihop med sin adjunkt,\n" +
                "och prosten stod på torget och tog en stilla runk.\n" +
                "\n" +
                "På rådhusporten spikades en kutta och en kuk,\n" +
                "som stodo mot betalning till allmänhetens bruk.\n" +
                "De unga och de gamla, de ställde sig i kö,\n" +
                "de voro fast beslutna att knulla eller dö.",
                ""));
        songs.Add(new Song(
                "Hon var så ensam",
                "Melodi: I Apladalen i Värnamo",
                "",
                "Flickorna: \n" +
                "Hon var så liten.\n" +
                "Hon var så frusen.\n" +
                "Hon hade istappar under musen.\n" +
                "(flickorna står upp och skakar på ändan)\n" +
                "TINGE LINGE LING\n" +
                "\n" +
                "Pojkarna: \n" +
                "Det var en stor en.\n" +
                "Det var en kall en.\n" +
                "Han hade istappar under ballen.\n" +
                "(pojkarna står upp och skakar på ändan)\n" +
                "DONG DONGE DONG",
                ""));
        songs.Add(new Song(
                "Äldre män",
                "Melodi: I Appladalen i Värnamo",
                "",
                "Äldre män ska man ej förakta.\n" +
                "De gör det noga, de gör det sakta.\n" +
                "Yngre män däremot är skit,\n" +
                "det är ju knappt att de hinner dit!",
                ""));
        songs.Add(new Song(
                "Gamle Niklas",
                "Melodi: I Apladalen i Värnamo",
                "",
                "Åh gamle Niklas tog fram kodongen.\n" +
                "Ja den han använt för sjunde gången.\n" +
                "Han sa till Hulda \"Jag har dig kär,\n" +
                "säg får jag knulla dig med den här?\".\n" +
                "\n" +
                "Han knulla luder och religiösa,\n" +
                "och med baptister och barnalösa.\n" +
                "Och bögars kukar han sög ibland\n" +
                "uppå ett pisshål i Mälarstrand.\n" +
                "\n" +
                "Hon var tju’sju år och hette Britta.\n" +
                "Hon hade Kungsholmens största fitta.\n" +
                "Hon hade bröst utav marsipan,\n" +
                "hon var ju hora den lilla fan.\n" +
                "\n" +
                "Och så en vecka efter leken,\n" +
                "det börja djävlas så smått i veken.\n" +
                "Först blev den lila, sen gredelin,\n" +
                "och måste smörjas med vaselin.\n" +
                "\n" +
                "Så gamle Niklas for till kliniken,\n" +
                "och drämde kuken i skrivbordsteaken.\n" +
                "Och syster rodna’, och doktorn sa:\n" +
                "\"Den lilla jäveln måst’ kortas av\".\n" +
                "\n" +
                "Och medan doktorn tog fram skalpellen\n" +
                "så sade systern som hette Ellen:\n" +
                "\"Det var ju synd på en prima kuk.\n" +
                "Den skulle passat uti min buk\".\n" +
                "\n" +
                "Och gamle Niklas han miste pålen,\n" +
                "och måste hålla i själva strålen.\n" +
                "Och det som skiljer han från en tjej,\n" +
                "det är att blygläppar har han ej.",
                ""));
        songs.Add(new Song(
                "Brittas fitta",
                "",
                "",
                "Ett, ett, kuken som ett spett\n" +
                "upp i Brittas fitta, kom får ni titta!\n" +
                "Två, två, kuken börjar stå, upp i…\n" +
                "Tre, tre, kuken står på sne’, upp i…\n" +
                "Fyra, fyra, kuken slår en lyra, upp i…\n" +
                "Fem, fem, kuken hittar hem, upp i…\n" +
                "Sex, sex, kuken käkar kex, upp i…\n" +
                "Sju, sju, kuken kommer nu, upp i…\n" +
                "Åtta, åtta, kuken börjar spotta, upp i…\n" +
                "Nio, nio, kuken går på bio, upp i…\n" +
                "Tio, tio, kuken far till Rio, upp i…\n" +
                "Elva, elva, kuken börjar skälva, upp i…\n" +
                "Tolv, tolv, kuken som en kolv, upp i…\n" +
                "Hundra, hundra, kuken börjar undra, upp i…\n" +
                "Tusen, tusen, kuken går i musen, \n" +
                "upp i Brittas fitta, kom får ni titta!",
                ""));
        songs.Add(new Song(
                "Horhuset",
                "Melodi: Du käre lille snickebo",
                "Text: Roger Melander",
                "Till bygdens horhus ränner jag när frugan min ej vill.\n" +
                "För kärringfan där hemma hon vill bara ligga still.\n" +
                "Flickorna ska hoppa omkring \n" +
                "och rida på min pille ville ving.\n" +
                "Då mår jag bra, hoppfallera.\n" +
                "Ja lyckos mig, hopp fallerej.\n" +
                "\n" +
                "På bygdens krog där ränner jag då törsten faller på.\n" +
                "Där hemma kan jag inget ha för hon slår ut det då.\n" +
                "Brännvin vill jag dricka min vän\n" +
                "och öl och vin och brännvin om igen.\n" +
                "Då mår jag bra, hoppfallera\n" +
                "Ja lyckos mig, hopp fallerej.",
                ""));
        songs.Add(new Song(
                "Horan och Idioten",
                "Melodi: Amanda Lundblom",
                "",
                "Det satt en hora på himmelsberge’,\n" +
                "Bom-fadderi fadderullan-berge’.\n" +
                "Och visa fittan för hela Sverige,\n" +
                "Bom-fadderi fadderullan-lej.\n" +
                "Men breve' satt en idiot,\n" +
                "Bom-fadderi fadderullan-lej,\n" +
                "Hugg i!\n" +
                "Och gnodde kuken med pepparrot,\n" +
                "Bom-fadderi fadderullan-lej.\n" +
                "",
                ""));
        songs.Add(new Song(
                "Gorkaleken",
                "Melodi: Om man inte har för stora pretentioner",
                "",
                "Nu jag sjunga vill en sång, om när jag var ung en gång\n" +
                "och besökte finska mässan uti Purkka.\n" +
                "Uti glada vänners lag, lekte vi en lek ett slag,\n" +
                "och den lekte vi med hjälp utav en gorka.\n" +
                "\n" +
                "Den gick till på detta vis: Först så skaffa vi ett pris,\n" +
                "en liter brännvin skulle vinnaren få dricka.\n" +
                "Sen så tog vi alla tre, och skaffade en gorka med,\n" +
                "och så tog vi hjälp utav en konstig schlicka.\n" +
                "\n" +
                "Uti hennes viitto vi, stoppa hela gorkan i\n" +
                "så att den for ut då vi slog hon på magen.\n" +
                "Den som sen fick gorkan mest, \n" +
                "ut på golvet han var bäst,\n" +
                "vi var tre grabbar som tävla hela dagen. \n" +
                "\n" +
                "Pekka var en starker man, \n" +
                "han vann brännvinsflaskan han\n" +
                "och som pris så fick han sätta sig att dricka.\n" +
                "Osquar kom på andra plats, ut i denna hårda match,\n" +
                "och som pris så fick han schnulla våran schlicka. \n" +
                "\n" +
                "Men se jag var också med, jag var sämst av alla tre\n" +
                "uti denna hårda match jag inte orka'.\n" +
                "Jag var alldeles för svag, ut i detta starka lag,\n" +
                "och som tröstpris fick jag äta våran gorka.\n" +
                "(…och den som hade legat på golvet!)",
                ""));
        songs.Add(new Song(
                "Inlandsbanan",
                "Melodi: Amanda Lundbom ",
                "",
                "När dom byggde inlandsbanan,\n" +
                "Bom-fadderi fadderallan-banan,\n" +
                "då blev alla flickor galna.\n" +
                "Bom-fadderi fadderallan-lej.\n" +
                "Skaffa sig en fästeman. \n" +
                "Bom-fadderi fadderallan-lej.\n" +
                "Hugg i!\n" +
                "Å pippa gjorde dom minsann.\n" +
                "Hej bom-fadderi fadderallan-lej.\n" +
                "\n" +
                "När dom sen på morron vakna, Bom... \n" +
                "börja dom sin mödom sakna, Bom... \n" +
                "gick så hem till mor och far, Bom... \n" +
                "Hugg i!\n" +
                "O mor, o mor, jag är med barn. Hej bom...  \n" +
                "\n" +
                "Mor, o mor, jag är en hora, Bom... \n" +
                "Mor, jag räknas till dom stora, Bom... \n" +
                "15 år och gängad mus, Bom... \n" +
                "Hugg i!\n" +
                "När dom andra kör med ljus. Hej bom...  \n" +
                "\n" +
                "Barn, o barn, du skall ej gråta, Bom... \n" +
                "Ännu finns det karlar kåta, Bom... \n" +
                "Barnet ditt, det tager jag, Bom... \n" +
                "Hugg i! Å dra!\n" +
                "Så pippa du, så vaggar jag. Hej bom...  ",
                ""));
        songs.Add(new Song(
                "Sven Ludvig Task",
                "Melodi: Kovan kommer",
                "",
                "Känner du Sven Ludvig Task?\n" +
                "Sven Ludvig Task, Sven Ludvig Task.\n" +
                "Kuken hans är som en mask.\n" +
                "Som en mask, som en mask.\n" +
                "Han kan hamra, han kan snickra.\n" +
                "Och visst kan han flickor smickra.\n" +
                "Men när han ska till att gör’t,\n" +
                "blir det oftast knut på snör’t.",
                ""));
        songs.Add(new Song(
                "Louisa Rask",
                "Melodi: Kovan kommer",
                "",
                "Har du sett Louisa Rask,\n" +
                "Louisa Rask, Louisa Rask.\n" +
                "Hon har fittan full med mask, \n" +
                "full med mask, full med mask.\n" +
                "Hon kan både sy och väva, \n" +
                "runka kuk med bägge näva'.\n" +
                "Sist hon gjorde fittan ren, \n" +
                "hitta hon en tegelsten.\n" +
                "Har du vart i Louisas säng, \n" +
                "Louisas säng, Louisas säng.\n" +
                "Det har varje karl med lem, \n" +
                "karl med lem, karl med lem.\n" +
                "Dit är inte svårt att hitta, \n" +
                "hela huset stinker fitta.\n" +
                "Även när hon har sin mens, \n" +
                "slukar hon den största fläns.",
                ""));
        songs.Add(new Song(
                "Märta",
                "Melodi: I Apladalen i Värnamo",
                "",
                "Hon var min fröjd och hon var min smärta\n" +
                "hon bar det klingande namnet Märta.\n" +
                "Vi bruka träffas nå’n gång ibland,\n" +
                "sen hon mitt hjärta satt i brand.\n" +
                "Vi satt i parken och konversera\n" +
                "då sade Märta ”Ska vi spatsera?\n" +
                "Vi går på staden en liten stund\n" +
                "sen får du följa mig på mitt rum.”\n" +
                "På ett bananskal som låg på vägen\n" +
                "där halka Märta och blev förlägen.\n" +
                "Ty kan ni gissa vad jag fick se?\n" +
                "Jo, Märta hade ett ben av trä.\n" +
                "Och när vi sedan kom fram till porten\n" +
                "var hon en flicka av rätta sorten.\n" +
                "Hon lyfte kjortelen upp en flik\n" +
                "där hängde portnyckeln på en spik.\n" +
                "Vi låg i sängen utan att somna\n" +
                "jag hörde sakta hur Märta domna\n" +
                "och till musiken av hennes snark\n" +
                "jag rista namnet i hennes bark.\n" +
                "Uppå en båttur det hemska hände\n" +
                "att båten sig upp och ner den vände\n" +
                "och stackars Märta hon finns ej mer\n" +
                "hon flöt för länge med huvet ner.\n" +
                "\n" +
                "Med denna visa vill jag påvisa\n" +
                "att kvinns med träben bör man avvisa.\n" +
                "Jag plockat stickor i fjorton dar\n" +
                "och har väl ändå minst hälften kvar.",
                ""));
        songs.Add(new Song(
                "I ett fönster",
                "Melodi: Säj inte nej säj kanske, kanske",
                "",
                "I ett fönster satt en flicka\n" +
                "Och onanerade så glatt\n" +
                "Hon hade uppkört en vibrerande\n" +
                "Massagestav i sin tratt\n" +
                "\n" +
                "Utanför stod en pojke\n" +
                "Och hans drule stod rakt ut\n" +
                "Han förhuden drog tillbaka\n" +
                "Och ur röret kom ett sprut\n" +
                "\n" +
                "Säj inte nej, säj pulla pulla pulla mig\n" +
                "Så ska jag knulla dig\n" +
                "Jag är så kåti-kåti-kåti-kåti-kåt\n" +
                "Säj inte nej, säj pulla, pulla, pulla mig.\n" +
                "Så ska jag knulla dig jag är så kåt …",
                ""));
        songs.Add(new Song(
                "Sir Charlie",
                "Melodi: Glory Glory",
                "",
                "||: Oh, Sir Charlie do not touch me :||\n" +
                "Said the girl in the bed with nothing on at all.",
                ""));
        songs.Add(new Song(
                "In kommer far",
                "Melodi: Å jänta å jag",
                "",
                "In kommer far, full som han var.\n" +
                "Drämde sin task i bordet.\n" +
                "Efter kommer mor, gorma och svor,\n" +
                "undra vad fan han gjorde.\n" +
                "Ska du förstöra pillevicken din\n" +
                "som du skall köra upp i kuttan min.\n" +
                "Barnen de skrek, katten han sket, \n" +
                "och farfar han stod och runka.",
                ""));
        songs.Add(new Song(
                "Bjällerklang",
                "",
                "",
                "Full och glad kommer jag\n" +
                "storstadsgatan fram.\n" +
                "Får ett snabbt ögonkast  \n" +
                "från en fin Madam. \n" +
                "Våt och varm, arm i arm \n" +
                "går vi till ett hus. \n" +
                "I en säng tar jag en sväng \n" +
                "i hennes sköna mus. \n" +
                "\n" +
                "Efter nån halv minut \n" +
                "tar all sperma slut. \n" +
                "Då vill hon ha bra betalt \n" +
                "men i pungen är det skralt. \n" +
                "Stor och ful stöddig man \n" +
                "ur garderoben fram. \n" +
                "Tittar ut med glättig min \n" +
                "och luktar brännevin.",
                ""));
        songs.Add(new Song(
                "Pisksnärtar friska",
                "Melodi: Vårvindar friska",
                "",
                "Pisksnärtar friska\n" +
                "vina och smiska,\n" +
                "sprider behag i hela min kropp.\n" +
                "Klatshigt det smäller,\n" +
                "brunstigt jag gnäller,\n" +
                "härligt, jag tror att jag kastar opp.\n" +
                "Bojorna kring min hals de dras åt.\n" +
                "Gud, jag tror nästan att jag blir kåt.\n" +
                "Risa mig duktigt,\n" +
                "ögat blir fuktigt,\n" +
                "jag gråter glädjens tår.\n" +
                "\n" +
                "Slagen blir värre\n" +
                "var nu min herre,\n" +
                "piska mig med din strumpebandsstropp.\n" +
                "Taggtråd kring magen\n" +
                "ökar behagen\n" +
                "uti min fordom välskapta kropp.\n" +
                "Blodet som strömmar ur öppna sår\n" +
                "klibbar så sakta fast i mitt hår.\n" +
                "Varbölder spricka,\n" +
                "O vilken flicka,\n" +
                "säkert blir du min död.",
                ""));
        songs.Add(new Song(
                "Sadistaria",
                "Melodi: Chaplins manschettvisa",
                "",
                "Jag föddes av min faster,\n" +
                "båd’ far och mor pedraster.\n" +
                "Jag levt mitt liv i laster.\n" +
                "Je suis Marquis de Sade.\n" +
                "\n" +
                "Min uppväxt på bordellen\n" +
                "tog slut med stora skrällen.\n" +
                "Värdinnan blev på smällen.\n" +
                "Je suis Marquis de Sade.\n" +
                "\n" +
                "När jag på flicka tänder,\n" +
                "får hon av piskan stora ränder.\n" +
                "Båd’ på mage rygg och länder.\n" +
                "Je suis Marquis de Sade.\n" +
                "\n" +
                "Jag älskar i naturen,\n" +
                "får umgås fritt med djuren.\n" +
                "Europa, hon med tjuren,\n" +
                "älskas av Marquis de Sade.\n" +
                "\n" +
                "Jag eggas ej av rosor,\n" +
                "av snus i gyllne dosor.\n" +
                "Blott när jag ett par trosor\n" +
                "får sätta på Marquis de Sade.\n" +
                "\n" +
                "Med blonda och brunetter\n" +
                "och nå’n gång med svarta getter.\n" +
                "Spenderas mina nätter.\n" +
                "Je suis Marquis de Sade.\n" +
                "\n" +
                "När jag kommit rätt i tagen\n" +
                "går jag ut i gröna hagen,\n" +
                "och tar en ko på magen.\n" +
                "Je suis Marquis de Sade\n" +
                "\n" +
                "När jag går på toiletten\n" +
                "har jag smärgel i boetten.\n" +
                "Det river gott i stjärten.\n" +
                "Je suis Marquis de Sade.\n" +
                "\n" +
                "Går jag sen upp mitt i natten\n" +
                "kissar jag en skvätt i hatten.\n" +
                "Se’n rinner det på kravatten.\n" +
                "Je suis Marquis de Sade.\n" +
                "\n" +
                "Mina vänner masochister,\n" +
                "nekrofiler och sadister.\n" +
                "Var blotterska min syster.\n" +
                "Je suis Marquis de Sade.\n" +
                "\n" +
                "Nu kan jag inte mera,\n" +
                "skall ut och masturbera.\n" +
                "Kom med så blir vi flera.\n" +
                "Je suis Marquis de Sade.",
                ""));
        songs.Add(new Song(
                "Samborombon",
                "Melodi: Fritiof och Carmensita",
                "",
                "Samborombon, en liten by förutan gata.\n" +
                "Har ändå flickor som med dig ej blott vill prata.\n" +
                "Nästan i kanten av den blåa Atlanten,\n" +
                "och med Pampas bakom sig\n" +
                "många hundra gröna mil.\n" +
                "Dit kom jag ridande en afton i april,\n" +
                "för jag ville rida ranka.\n" +
                "\n" +
                "Skratt, skrik och vällustiga stön \n" +
                "hördes från huset och från många kåta kön.\n" +
                "Jag steg in, löste biljetten\n" +
                "och styrde stegen mot en säng\n" +
                "med den florerande lilla Carmensita.\n" +
                "Mamman den horan satt i vrån.\n" +
                "Hon gav mig ett ridspö, en pistong och en kondom.\n" +
                "Jag bjöd upp och Carmensita sa:\n" +
                "Si gracias, senór, Vámos á bailár rida ranka!\n" +
                "\n" +
                "Carmencita lilla vän, \n" +
                "har du ej slutat fnaska än?\n" +
                "Får jag tala med din mamma och din hallick,\n" +
                "jag vill ha dig för mig själv Carmencita!\n" +
                "Nej, Don Fritiof Andersson,\n" +
                "kom ej till Samborombon\n" +
                "om ni hyser andra planer när det gäller mig,\n" +
                "än att rida ranka.\n" +
                "\n" +
                "Ack Carmencita gör mig inte så besviken.\n" +
                "Jag hade tänkt ägna mig helt åt erotiken,\n" +
                "sköta staken noga, spara safter och knoga.\n" +
                "Inte spela och dricka utan bara knoppa dig.\n" +
                "Säg Carmencita det är väl ändå blott med mig,\n" +
                "säg som ni vill rida ranka. \n" +
                "\n" +
                "Nej, Fritiof ni kan erotik,\n" +
                "men jag tror hellre jag vill ligga i butik.\n" +
                "Och förresten sa min mamma just idag\n" +
                "att hon visste vem som snart skulle\n" +
                "knoppa hennes dotter.\n" +
                "En som har tjugotusen kor,\n" +
                "och som är underbar på att bedriva hor.\n" +
                "Han har prisbelönta tjurar.\n" +
                "Han har oxar, får och svin.\n" +
                "Och han rider underbar ranka. \n" +
                "\n" +
                "Carmencita lilla vän,\n" +
                "akta dig för rik mans lem!\n" +
                "Lyckan den bor ej i statskontrollerad hor\n" +
                "och den kan heller inte köpas i sängar. (Jodå!)\n" +
                "Men min brandslang gör dig stinn\n" +
                "sprutar ända in i gommen din!\n" +
                "Och om det går galet, kåta ungar ska vi få\n" +
                "som kan rida ranka.",
                ""));
        songs.Add(new Song(
                "Snorkråkan",
                "Melodi: Vi på saltkråkan  ",
                "",
                "Vad det är skönt att stå här ner vid sjön och dra kuk.\n" +
                "Melker står och runkar. \n" +
                "Båtsman, Båtsman har en djävla jätttekuk!\n" +
                "\n" +
                "Malin äter flänsost varje dag, tralala.\n" +
                "Ollonet det blänker.\n" +
                "Peter njuter när hon tar hans kuk i mun.  \n" +
                "\n" +
                "Å kåta Malin hon fick gonorré nu i kväll.\n" +
                "Nu har hela ön det.\n" +
                "Kåta Malin hon fick gonorré i kväll.\n" +
                "\n" +
                "Lilla Stina vet knappt hur en kuk skall se ut.\n" +
                "Hon har inget könshår.\n" +
                "Men hon, men hon leker med sin säl var dag.\n" +
                "\n" +
                "Tjorven pullar kuttan gul å blå varje dag.\n" +
                "Melkers stora balle.\n" +
                "Båtsman, Båtsman har en djävla jättekuk!\n" +
                "\n" +
                "Å feta Tjorven hon vill ha en tjej nu i kväll.\n" +
                "Malin satte på´na.\n" +
                "Feta Tjorven spräckt utav en kvinnohand.\n" +
                "\n" +
                "Teddie Freddie leker med varann´ mest var dag.\n" +
                "I en 69:a.\n" +
                "Incest, incest på deras familjefest.\n" +
                "\n" +
                "Lilla Pelle kelar med sin vita kanin.\n" +
                "Räddad utav el-tejp.\n" +
                "Annars hade den nog spruckit mitt itu.\n" +
                "\n" +
                "Farbror Melker är vår pedofil här på ön.\n" +
                "Stina är besudlad.\n" +
                "Melkers lem är färgad röd av hennes blod.\n" +
                "\n" +
                "Österman han njuter med en ål i sitt hål.\n" +
                "Han känner hur den krälar.\n" +
                "Skiten sprutar när den åker in och ut.",
                ""));
        songs.Add(new Song(
                "Än en gång därin",
                "Melodi: Än en gång däran",
                "",
                "Än en gång därin, bröder, än en gång därin.\n" +
                "Följom den urgamla säden!\n" +
                "Intill sista tum, bröder, intill sista tum,\n" +
                "spräcker vi mödis på pläden.\n" +
                "Blankare ollon sågs aldrig i en här\n" +
                "än dessa kukar. Kamrater, i gevär!\n" +
                "Än en gång därin, bröder, än en gång därin!\n" +
                "Svenska fittors djup, här är din kuk!",
                ""));
        songs.Add(new Song(
                "Far och mor ",
                "Melodi: Hallå du gamle indian",
                "",
                "Har du sett min far,\n" +
                "en så’n kuk han har.\n" +
                "Han kör posten i klippiga bergen.\n" +
                "Har du sett min mor,\n" +
                "med en fitta så stor.\n" +
                "Den är slemmig och lila till färgen.",
                ""));
        songs.Add(new Song(
                "Scoutledar-Frasse",
                "",
                "",
                "Vem knackar på min dörr, vem knackar på min dörr, vem knackar på min dörr, sa den väna jungfrun.\n" +
                "Det är jag med patrull som är här för ett knull,\n" +
                "sa Scoutledar-Frasse\n" +
                "Du får stanna här i natt...\n" +
                "En timme får det ta, det är fler som ska ha...\n" +
                "Det kostar tio spänn...\n" +
                "Jag skiter i tian, vi kör sextinian...\n" +
                "Du får sova på min arm...\n" +
                "Jag skiter i armen, kör upp den i tarmen...\n" +
                "Ni får tvätta er vid källan…\n" +
                "Vi skiter i brunnen, ta den i munnen \n" +
                "Du får tala med min mor...\n" +
                "Din mor hon får duga, hon är bra på att suga...\n" +
                "Får jag bjuda på champagne...\n" +
                "Jag skiter i skumpan, kör rätt upp i rumpan...\n" +
                "Ni får sova ibland fåren…\n" +
                "Vi skiter i fåren, kör rätt mellan låren\n" +
                "Du får viska vackra ord...\n" +
                "Jag skiter i tugget, kör rätt upp i hugget...\n" +
                "Men tänk på infektion...\n" +
                "Jag skiter i smittan, kör upp den i fittan...\n" +
                "\n" +
                "Du får tala med min bror Herman...\n" +
                "Jag skiter i Herman, för nu kommer sperman...\n" +
                "Du får torka upp sperman...\n" +
                "Jag skiter i sperman, för nu tar jag Herman...",
                ""));
        songs.Add(new Song(
                "Dra ollon",
                "Melodi: Frukostklubben ",
                "",
                "Innan vi går ut i stadens jäkt och jobb \n" +
                "så sjunger vi en enkel sång \n" +
                "i våran runkarklubb: \n" +
                "Dra ollon, dra ollon \n" +
                "här är vår runkarklubb, \n" +
                "dra ollon, dra ollon i kör! \n" +
                "\n" +
                "Innan vi går ut i stadens jäkt och rus \n" +
                "så kör vi upp en gurka stor \n" +
                "i våran lilla mus: \n" +
                "Dra gurka, dra gurka \n" +
                "i våran gurkaklubb, \n" +
                "dra gurka, dra gurka i kör! \n" +
                "\n" +
                "Jag är en liten ekorre \n" +
                "som handlar i affär. \n" +
                "och när jag släpar hem min mat\n" +
                "så sjunger jag så här: \n" +
                "Dra ollon, dra ollon,\n" +
                "fyll hela kylskåpet,\n" +
                "dra ollon, dra ollon, hej då!",
                ""));
        songs.Add(new Song(
                "The engineer song ",
                "Melodi: Ghost rider",
                "",
                "An engineer told me before he died, \n" +
                "Ah hum, titty bum, titty bum, titty bum\n" +
                "An engineer told me before he died, \n" +
                "Ah-hum, ah-hum!\n" +
                "An engineer told me before he died, \n" +
                "and I've no reason to think he lied.\n" +
                "Ah hum, titty bum, titty bum, titty bum\n" +
                "\n" +
                "He had a wife with a cunt so wide.\n" +
                "That she could never be satisfied.  \n" +
                "\n" +
                "So he built a fucking great wheel.\n" +
                "With two Brass balls and a prick of steel.\n" +
                "\n" +
                "The balls of Brass he filled with cream.\n" +
                "And the whole bloody thing was powered by steam. \n" +
                "\n" +
                "He tied her down onto the bed.\n" +
                "And lashed her arms above her head.\n" +
                "\n" +
                "There she lay demanding a fuck.\n" +
                "He shook her hand and he wished her luck. \n" +
                "\n" +
                "Round and round went the fucking great wheel.\n" +
                "In and out went the prick of steel. \n" +
                "\n" +
                "\n" +
                "Up and up went the level of steam.\n" +
                "Down and down went the level of cream. \n" +
                "\n" +
                "Till at last the maiden cried.\n" +
                "Enough, enough, I'm satisfied. \n" +
                "\n" +
                "Now we've come to the tragic bit.\n" +
                "There was no way of stopping it.\n" +
                "\n" +
                "She was split from arse to tit.\n" +
                "And the whole bloody room was covered in shit.\n" +
                "\n" +
                "It jumped off her and it jumped on him.\n" +
                "And then it went after his next of kin.\n" +
                "\n" +
                "It jumped onto a cross town bus.\n" +
                "It's coming to fuck the rest of us! \n" +
                "\n" +
                "The moral of this story is clearly seen.\n" +
                "Never trust a fucking machine. ",
                ""));
        songs.Add(new Song(
                "Kyrkvisa",
                "Melodi: Tryggare kan ingen vara ",
                "",
                "Han som samla upp kollekten \n" +
                "gick åstad och sket i fläkten. \n" +
                "De som hade bra placering, \n" +
                "de fick gratis sprutlackering.",
                ""));
        songs.Add(new Song(
                "The ball of Killiemuir ",
                "",
                "",
                "The Ball, the Ball, the Ball of Killiemuir.\n" +
                "Where your wife and my wife were doing it on the floor.\n" +
                "\n" +
                "Four and twenty virgins came down from Inverness.\n" +
                "When the ball was over there were four and twenty less.\n" +
                "\n" +
                "Swing your balls against your partner, and your ass against the wall.\n" +
                "If you never get laid on a Saturday night, you'll never get laid at all.\n" +
                "\n" +
                "Four and twenty whores, came up from Glockamore,\n" +
                "Only one went home that night and she was double bore.\n" +
                "\n" +
                "Farmer Giles he was there, a sickle in his hand.\n" +
                "Every time he swung around he circumcised the band.\n" +
                "\n" +
                "The village Magician he was there, performing his favourite trick.\n" +
                "By pulling the foreskin over his head, and vanishing up his prick.\n" +
                "\n" +
                "The magician's Assistant she was there, in her favourite role.\n" +
                "She put her head between her legs and vanished up her hole.\n" +
                "\n" +
                "The village Vicar he was there, and in a corner sat.\n" +
                "Amusing himself by abusing himself and catching it in his hat.\n" +
                "\n" +
                "The Vicars Daughter she was there, performing a stumbling stunt. \n" +
                "Hanging from the ceiling by the suction of her cunt.\n" +
                "\n" +
                "The village Cripple he was there, he wasn’t up to much.\n" +
                "He lined them up against the wall and fucked them with his crutch.\n" +
                "\n" +
                "The village Smithy, he was there, his prick was ironware.\n" +
                "When the first begun to rust, he swapped it for a spare.\n" +
                "\n" +
                "The village Postman he was there, he had a case of pox.\n" +
                "He couldn't fuck the ladies so he fucked the letterbox.\n" +
                "\n" +
                "They where fucking in the kitchen, they where fucking in the halls.\n" +
                "You couldn’t here the music for the clinging of the balls.\n" +
                "\n" +
                "First lady forward, second lady back.\n" +
                "Third lady's finger up the fourth lady's crack.\n" +
                "\n" +
                "The Bride was in the parlour explaining to the Groom.\n" +
                "The vagina, not the rectum is the entrance to the womb.\n" +
                "\n" +
                "The Groom was in the bedroom explaining to the Bride\n" +
                "The Penis not the scrotum is the part that goes inside.\n" +
                "\n" +
                "Little Tommy he was there, but he was only eight.\n" +
                "Too young for the ladies so he had to masturbate.\n" +
                "\n" +
                "The village Shepard he was there, and he began to weep.\n" +
                "All these willing ladies and not a single sheep!\n" +
                "\n" +
                "Sergeant O’Malley he was there, the pride of all the force.\n" +
                "They caught him in the stable, wanking off his horse!\n" +
                "\n" +
                "Mrs. O'Malley she was there, swinging from the chandelier,\n" +
                "Spilling her menstrual juices into everybody's ear.\n" +
                "\n" +
                "The village Whore she was there, she kept the crowd in fits.\n" +
                "Sliding down the banister and bouncing on her tits.\n" +
                "\n" +
                "The village Pervert he was there, scratching at his crotch,\n" +
                "But no one minded him he was only there to watch!\n" +
                "\n" +
                "The village Madam she was there, a-lying on the floor.\n" +
                "Every time she spread her legs the suction slammed the door.\n" +
                "\n" +
                "The Blacksmith's brother he was there, a mighty stud was he.\n" +
                "Lined 'em up against the wall and fucked 'em three-by-three.\n" +
                "\n" +
                "The village Baker he was there and looking pretty mean.\n" +
                "A-shouting that the girls were tarts, and pumping them full of cream!\n" +
                "\n" +
                "The village Dwarf was also there, that randy little runt.\n" +
                "He'd dive upon a lassie, headfirst in her cunt!\n" +
                "\n" +
                "The village Doctor he was there, he had his bag of tricks\n" +
                "And in between the dances he was sterilizing pricks!\n" +
                "\n" +
                "The village Plumber he was there, he felt an awful fool;\n" +
                "He'd come eleven leagues or more and forgot to bring his tool!\n" +
                "\n" +
                "The deaf mute lad was also there, and didn't have much to say.\n" +
                "Waitin' for the lasses to faint, and doin' 'em where they lay.\n" +
                "\n" +
                "The village idiot he was there, sitting on a pole.\n" +
                "Pulled his foreskin over his head and whistled though the hole.\n" +
                "\n" +
                "The village virgin she was there, all dressed in frilly pink.\n" +
                "She took the boys behind the fence and made their fingers stink.\n" +
                "\n" +
                "The village veteran he was there, his balls were made of brass.\n" +
                "And when he blew a fart, my lads, the sparks flew out his ass.\n" +
                "\n" +
                "The village leper he was there, sitting on a log.\n" +
                "Peeling foreskin off his cock and feeding it to his dog.\n" +
                "\n" +
                "The village cook he was there, the bastard was quite crude.\n" +
                "They caught him in the kitchen masturbating in the food.\n" +
                "\n" +
                "The Chimney Sweeper he was there, but he soon got the boot. \n" +
                "For every time he farted he filled the room with soot.\n" +
                "\n" +
                "I put my head upon her lap, and she put hers in mine.\n" +
                "We sucked a bit and blew a bit and that's called sixty-nine.\n" +
                "\n" +
                "First they did it simple, then tried it he's and she's.\n" +
                "But before the ball was over, they went at it fives and threes!\n" +
                "\n" +
                "They were fucking in the barley. They were fucking in the oats.\n" +
                "Some were fucking sheep but most were fucking goats.\n" +
                "\n" +
                "There was fucking in the barns, and fucking on the ricks.\n" +
                "You couldn't hear the music for the swishing of the pricks.\n" +
                "\n" +
                "There was fucking in the parlour. There was fucking in the stairs.\n" +
                "You couldn't see the carpet for the mass of pubic hairs.\n" +
                "\n" +
                "There was fucking in the grass. There was fucking on the stones.\n" +
                "You couldn’t here the music for the joyful screams and moans.\n" +
                "\n" +
                "And when the ball was over, they all had to confess.\n" +
                "Although they liked the music, the fucking was the best!",
                ""));
        songs.Add(new Song(
                "När gräset gror",
                "Melodi: När gäddorna leker",
                "",
                "När gräset gror på ängarna\n" +
                "går pigorna till drängarna. \n" +
                "Ja då är det vår, \n" +
                "och helan går.\n" +
                "\n" +
                "När pigorna går där med hängiga bröst \n" +
                "och drängarna inte längre har lust, \n" +
                "ja då är det höst, \n" +
                "men brännvin ger tröst.",
                ""));
        songs.Add(new Song(
                "69:an",
                "Melodi: 34:an",
                "",
                "Denna ställning har vi prövat uti många herrans år.\n" +
                "Denna ställning har vi kört å den är inte särskilt svår.\n" +
                "Men så plötsligt häromdan bak i en bil så sa det knäck.\n" +
                "Å nu ligger vi då här som två tomater i en säck.\n" +
                "\n" +
                "||: Så nu är det slut på sex och lekar.\n" +
                "Ja, nu är det färdigt inom kort.\n" +
                "Vi sitter fast uti varandra\n" +
                "å vi kan ej komma loss.\n" +
                "Å du tar farväl med vänster stortå fast uti min mun.\n" +
                "Vi sitter fast uti varandra\n" +
                "vi går i 69:an i himlen in. :||",
                ""));
        songs.Add(new Song(
                "Välkomstvisan",
                "Melodi: Räven raskar över isen",
                "",
                "Sperman rinner genom strupen.\n" +
                "Sperman rinner genom strupen.\n" +
                "Samlar sig, samlar sig\n" +
                "i små klumpar i djupen.\n" +
                "Flickan gapar med mun och hål.\n" +
                "Och du ska ge henne vad hon tål.\n" +
                "Å får jag se’n, å får jag se’n,\n" +
                "så vill jag knulla dig i röven.",
                ""));
        songs.Add(new Song(
                "Satsen kommer",
                "Melodi: Glada änkan",
                "",
                "Satsen kommer, satsen kommer\n" +
                "god och varm.\n" +
                "Kvinnor kvider när jag gnider\n" +
                "deras barm.\n" +
                "När min kuk den vuxit.\n" +
                "Ja, när den vecklats ut.\n" +
                "Kommer alla flickor hit\n" +
                "för att få ett skjut.",
                ""));
        songs.Add(new Song(
                "Katten den har fyra ben ",
                "Melodi: Mitt lilla face och jag",
                "",
                "Katten den har fyra ben.\n" +
                "Tuppen den har två\n" +
                "Snoppen den har inga alls,\n" +
                "men den kan stå ändå!",
                ""));
        songs.Add(new Song(
                "En liten marsipanvisa",
                "Melodi: Vi sätter oss i ringen.",
                "",
                "Vi sätter oss i ringen\n" +
                "och tar nånting i hand.\n" +
                "Vi är en massa syskon\n" +
                "som sätter på varann.\n" +
                "Men vi har inga gummin\n" +
                "det blir en massa barn.\n" +
                "Och de blir alla fina\n" +
                "de smakar marsipan. ",
                ""));
        songs.Add(new Song(
                "Int' för jag har",
                "Melodi: Å jänta å ja ",
                "",
                "Int’ för jag har så stor pitt som far,\n" +
                "men jag drar på med stumpen jag har.\n" +
                "Hej hopp i tak, stor mus har jag,\n" +
                "och fem ballar går det i ’na",
                ""));
        songs.Add(new Song(
                "Aj Aj Aj",
                "",
                "",
                "Aj, aj, aj,  \n" +
                "det svider när jag kissar.  \n" +
                "Aj, aj, aj,  \n" +
                "sen jag gängade dig.  \n" +
                "Aj, aj, aj,  \n" +
                "jag nu stolen missar,  \n" +
                "aj, aj, aj,\n" +
                "sen jag gängade dig.  ",
                ""));
        songs.Add(new Song(
                "Prostata",
                "Melodi: Ratata",
                "",
                "En afton uppå Stureplan \n" +
                "gick Agda av och an.\n" +
                "Med purpurblod på läpparna, \n" +
                "från Kungsgatan kom han. \n" +
                "En blink, en blick, en nick, \n" +
                "ett napp och så var saken klar. \n" +
                "Fidelirum skål uti galet hål, \n" +
                "och så var staken klar.  \n" +
                "\n" +
                "Prostata han blåste uti tuban. \n" +
                "Prostata från Mons till Vulva ljöd. \n" +
                "Prostata, prostata, blixt och dunder här är jag.\n" +
                "Men det blev hans bleka död.  \n" +
                "\n" +
                "De vandrade en gata fram \n" +
                "som fått namn av Birger Jarl. \n" +
                "Som krigade och älskade \n" +
                "och söp uti sin sal. \n" +
                "En mullig mö, ett krus med öl, \n" +
                "och så var saken klar. \n" +
                "Fidelurum skål uti galet hål \n" +
                "och så var staken klar.  \n" +
                "\n" +
                "Prostata...\n" +
                "\n" +
                "En port slås strax igen \n" +
                "bakom de våra unga tu. \n" +
                "De traskade sig trötta \n" +
                "uppför dryga trappor sju. \n" +
                "Hon var så trött, så trött, så trött, \n" +
                "när han slog upp sin dörr. \n" +
                "Han var andfådd han, hon var ganska van, \n" +
                "hon hade gått där förr.  \n" +
                "\n" +
                "Prostata...\n" +
                "  \n" +
                "Men allt rann ut i sängen, \n" +
                "av hans fina helkvällsplan. \n" +
                "Från Borlänge han kommit  \n" +
                "för att roa sig i stan. \n" +
                "Dock lyckades han pressa fram \n" +
                "när ögonen han slöt. \n" +
                "Fidelurum skål uti galet hål \n" +
                "en sista tapper stöt.  ",
                ""));
        songs.Add(new Song(
                "Ekorren satt i tallen",
                "Melodi: Ekorren satt i granen",
                "",
                "Ekorrn satt i granen\n" +
                "bryggde lite planksaft.\n" +
                "Därav blev han knall, men\n" +
                "överfylld av man-kraft.\n" +
                "Hoppa han till stugan så,\n" +
                "våldtog katten och gick på\n" +
                "med den långa ludna svansen.",
                ""));
        songs.Add(new Song(
                "Den är för liten",
                "Melodi: Någonstans i Sverige ",
                "",
                "Hans axlar är för smala\n" +
                "Och hans stjärt är för stor.\n" +
                "Hans ben är rätt skrala,\n" +
                "han kan ej bedriva hor.\n" +
                "Men det gör detsamma för det går ju ändå,\n" +
                "för jag har en annan.\n" +
                "\n" +
                "Hans kropp är rätt sliten\n" +
                "och hans kulor är för små.\n" +
                "Hans kuk den är för liten\n" +
                "och den vill inte stå.\n" +
                "Men det gör detsamma för det går ju ändå,\n" +
                "för jag har en annan.",
                ""));
        songs.Add(new Song(
                "Lilla Lisa",
                "Melodi: Där som sädesfälten",
                "",
                "När som sädesvätskan rinner ner för magen, \n" +
                "lilla Lisa hon var bara fjorton år.\n" +
                "Jag kan se att hon är ganska så betagen\n" +
                "när jag trycker upp min kuk mot hennes lår. \n" +
                "Hennes ögon dom var fyllda utav smärta.\n" +
                "Hennes sköte det var fyllt av hennes blod.\n" +
                "Och då tänker jag på gamla horan Berta\n" +
                "i vars fitta man får in ett matsalsbord.\n" +
                "\n" +
                "… med kandelabrarna på!",
                ""));
        songs.Add(new Song(
                "Ovan där",
                "Melodi: Ovan där",
                "",
                "Frestelser man stöter på, när på gatorna man går, \n" +
                "för där möter man ju flickor, som utan BH går. \n" +
                "När en flick är så bar, är det svårt att vara karl, \n" +
                "särskilt när man är så ovan vid sån't där.  \n" +
                "Ovan där, under klänningen, \n" +
                "se på jumpern, erfar spänningen. \n" +
                "Nog kan jag väl gissa vad som buktar där, \n" +
                "men jag är så alld'les ovan där.\n" +
                "\n" +
                "Jag har läst FIB-Aktuellt och sett flickorna som snällt \n" +
                "viker ut sig, och de jobbar säkert rent och ideellt, \n" +
                "men vad hjälper det väl mig, jag får aldrig någon tjej, \n" +
                "för jag är så rent förbannat ovan där.  \n" +
                "Ovan där, vid all nakenhet, \n" +
                "och min flicka sa \"Du är för het\". \n" +
                "När jag börja kladda blev hon plötsligt tvär, \n" +
                "och hon klagade \"Du är för ovan där\".  \n" +
                "\n" +
                "När jag var uppå galej träffa jag en raggartjej, \n" +
                "och jag tände till tusen, men då nobbade hon mig. \n" +
                "Inför trycket av min hand blev hon som en konfirmand, \n" +
                "och hon stönade \"Han är för grov, han där.\"  \n" +
                "Grov, han där, han är fräck i mun. \n" +
                "Jag gick miste om min kärleksstund, \n" +
                "Att ragga flickor leder bara till besvär, \n" +
                "särskilt om man är så ovan vid sånt där. ",
                ""));
        songs.Add(new Song(
                "Lilla vackra Anna",
                "Melodi: Lilla vackra Anna ",
                "",
                "Lilla vackra Anna om du vill \n" +
                "släppa hela stora fittan till. \n" +
                "Så ska vi försöka \n" +
                "att vår släkt föröka. \n" +
                "Lilla vackra Anna om du vill. \n" +
                "\n" +
                "Lilla vackra Anna om du vill \n" +
                "vända också andra sidan till. \n" +
                "Du är öm i blicken, \n" +
                "jag är styv i picken. \n" +
                "Lilla vackra Anna om du vill.",
                ""));
        songs.Add(new Song(
                "Ponny",
                "Melodi: Min kära lilla ponny",
                "",
                "Vad du är åh! Min kära lilla ponny.\n" +
                "Vad du är åh! Min kära lilla häst.\n" +
                "Du kommer aldrig först, min kära lilla ponny,\n" +
                "och du är den som gör det bäst.\n" +
                "\n" +
                "Vad den är åh! Min kära lilla ponny.\n" +
                "Den är så åh! Min kära lilla häst.\n" +
                "Jag gränslar dig med tvång min kära lilla ponny.\n" +
                "Allt med en säker invand gest.",
                ""));
        songs.Add(new Song(
                "Amanda",
                "Melodi: I apladalen i Värnamo",
                "",
                "Amanda gångar sig ut i lunden\n" +
                "där får hon se att en ko står bunden.\n" +
                "Amanda gångar sig hem igen\n" +
                "slår upp en nubbe och sveper den.\n" +
                "\n" +
                "Amanda gångar sig ned till stranden \n" +
                "å sätter röva sin ner i sanden. \n" +
                "Där kom en bergsman och spotta snus. \n" +
                "han spottar rakt i Amandas mus.\n" +
                "\n" +
                "Amanda har nu fått en dotter \n" +
                "som säljer musa sin på lotter. \n" +
                "Där kom en bergsman och drog en nit. \n" +
                "Han blev förbannad och slog en skit. \n" +
                "\n" +
                "Amanda har nu blitt till åren \n" +
                "och plockar flatlöss emellan låren. \n" +
                "Ju mer hon plocka, desto mer hon fann. \n" +
                "En gång hon plocka tills tårar rann.",
                ""));
        songs.Add(new Song(
                "Balladen om Theobald Thor",
                "",
                "",
                "En man som hette Theobald Thor\n" +
                "han var en skicklig tamburmajor.\n" +
                "Succén han gjorde var alltid stor\n" +
                "när han snurra och svängde sin kuk.\n" +
                "\n" +
                "För det var en stor kuk.\n" +
                "Lång och kraftig och tung.\n" +
                "Från dess topp till dess rot\n" +
                "var den tre, fyra fot,\n" +
                "och en medelstor ryggsäck till pung, pung, pung.\n" +
                "\n" +
                "En dag gick Theobald ut en stund\n" +
                "att gå för sig själv i en lummig lund.\n" +
                "Han mötte en söt liten dam med en hund\n" +
                "som fick se honom svänga sin kuk.\n" +
                "\n" +
                "Och Theobald pröva han ett trick han lärt.\n" +
                "Han släppte sin lem med en kraftig snärt\n" +
                "i huvudet på hunden som avled tvärt\n" +
                "när han snurra och svängde sin kuk.\n" +
                "\n" +
                "Men damen hon blev bestört\n" +
                "hon svor och skrek nå´t oerhört\n" +
                "så det var ingen lyckad flirt\n" +
                "att snurra och svänga sin kuk.\n" +
                "\n" +
                "Till följd av damens arga gnäll.\n" +
                "Han anhölls redan samma kväll\n" +
                "och sattes i en ensam cell\n" +
                "att snurra och svänga sin kuk.\n" +
                "\n" +
                "När målet kom i rätten opp,\n" +
                "sa åklagarn´, ”Det får bli stopp\n" +
                "man får ej vifta med sin snopp\n" +
                "och snurra och svänga sin kuk”.\n" +
                "\n" +
                "Men domarn´ han var tolerant.\n" +
                "Han sa, ”Själv gör jag likadant\n" +
                "jag tycker det är intressant\n" +
                "att snurra och svänga min kuk”.\n" +
                "\n" +
                "Så Theobald han släpptes fri\n" +
                "och liksom domarn tycker vi \n" +
                "att damer dom ska skita i\n" +
                "om man snurrar och svänger sin kuk ",
                ""));
        songs.Add(new Song(
                "I röva",
                "Melodi: Viggen",
                "",
                "I röva på en gris,\n" +
                "där växer lingonris,\n" +
                "i röva på en gammal tant\n" +
                "där växer likadant.\n" +
                "I röva på en häst,\n" +
                "där växer allra bäst,\n" +
                "i röva på min onkel Per,\n" +
                "där växa kånkelbär.",
                ""));
        songs.Add(new Song(
                "Jannes snuskvisa",
                "Melodi: My bonnie",
                "Text: Janne Weijnitz, Djurmästeriet, DISK KM",
                "Pojke: Min förhud är röd och den svider.\n" +
                "Flicka: Min framstjärt är öm och gör ont.\n" +
                "Båda:   Vi har ju haft kul hela natten,\n" +
                "             och knullat runt mest hela da´n.\n" +
                "Flicka: Samlag, samlag, jag tror att jag vill bli \n" +
                "            med barn, med barn.\n" +
                "Pojke:  Samlag, samlag, då kör jag dig med\n" +
                "            en banan, fy fan!",
                ""));
        songs.Add(new Song(
                "Intellektuell visa",
                "Melodi: Räven raska över isen",
                "",
                "Räven raska röva riset.\n" +
                "Riset raska renar räven.\n" +
                "Å röva ris, å röva rös.\n" +
                "Å riva räven i röven.\n" +
                "Finne finna femton flaskor\n" +
                "Flickan finna finnen fyller\n" +
                "Å finnen fes, å flickan fås.\n" +
                "Å riva flickan å flaskan\n" +
                "Lisa längtar leva loppan.\n" +
                "Ludvig längtar Lisa lära.\n" +
                "Å Lisa låg och läxan lär.\n" +
                "Å leva loppan i ladan ",
                ""));

        songs.Add(new Song(
                "Jul på Saltkråkan",
                "Melodi: Vi på Saltkråkan",
                "",
                "Det är så vackert när det ligger snö på vår sjö.\n" +
                "Melkers står och metar.\n" +
                "Båtsman, Båtsman han har is uti sin päls.\n" +
                "\n" +
                "Söta Malin äter på en pepparskaksdeg.\n" +
                "Julestjärnan blänker.\n" +
                "Pelle njuter när det nu är jul igen.\n" +
                "\n" +
                "Å söta Malin hon vill fira jul nu ikväll.\n" +
                "Nu gör hela ön det.\n" +
                "Söta Malin hon fick klappar nu ikväll.\n" +
                "\n" +
                "Lilla Stina hon vet ej att Tomten inte finns.\n" +
                "Hon har ingen aning.\n" +
                "Hon har önskat sig en säl varenda dag.\n" +
                "\n" +
                "Å käcka Tjorven hon vill se på TV ikväll.\n" +
                "Malin satte på den.\n" +
                "Käcka Tjorven ser på Kalle Anka nu.\n" +
                "\n" +
                "Österman han leker med sin nya present\n" +
                "En doktors gummihandske.\n" +
                "Skummet sprutar när den in i disken far.",
                ""));

        songs.Add(new Song(
                "Trasig marskalk",
                "Melodi: Jag är fattig bonddräng",
                "",
                "Jag är trasig marskalk men jag lever ändå.\n" +
                "Pubar går och kommer medan jag knogar på.\n" +
                "Svabbar, går och tömmer, sköljer, torkar och bär.\n" +
                "Står med Falcon tappen häller öl till vår här.\n" +
                "\n" +
                "Jag är trasig marskalk och har capsat i grus.\n" +
                "Uti vida världen har jag skaffat ett rus.\n" +
                "Hånglat, grovat, horat har jag också förstås.\n" +
                "Bytt en massa märken så har jag festat loss.\n" +
                "\n" +
                "Så gått alla pubar, fester, roligt och kul.\n" +
                "Med de alla arren och med andra haft strul.\n" +
                "Meister, Spritis, Klubba, ja terminerna ut.\n" +
                "Åren som en marskalk de har nu tagit slut.\n" +
                "\n" +
                "Men då säger Razor ”Trasig marskalk kom hit!\n" +
                "Jag har sett din strävan och ditt eviga slit.\n" +
                "Därför trasig marskalk är du välkommen här.\n" +
                "Därför trasig marskalk skall du vara mig när.”\n" +
                "\n" +
                "Och jag trasig marskalk står så still inför Gud.\n" +
                "Iklädd svart och guld i våran heliga skrud.\n" +
                "”Nu du”, säger Razor ,”är ditt arbete slut.\n" +
                "Nu du trasig marskalk, nu får du vila ut.”",
                ""));

		songs.Add(new Song(
			"Horungen",
			"Melodi: Muslåten i askungen",
			"Text: Åhlen & Brumma",
			@"Förteater:
'Horungen, horungen!!'

'Ja, ja, jag kommer!'
        
mus1:
'Stackars horungen'
'Knappt har hon en man att knulla'
'Ropar de vi vill pulla'
'Kom genast hit, Kom genast hit'

'HORUNGEN!'

Vi ska suga vi ska slicka
på varenda kuk å fitta
spruta skumpan upp i rumpan
vi nu varandra humpar
vi spyr och söker hitta
varenda pung och klitta
med kådisar i rad
vi suger av ett hundratal
och dricker upp all sperma som vi nu kan hitta

mus1:
'Ja, knulla på ni'
'Vet ni vad?'
'Horungen får nog inte analt'

andramöss:
'Va? Inte det?'
'Vad var det du sa?'
        
mus1:
'Ni ska få se'
'Hon är inte blekt'
'Bara smisk, smisk, smisk'
'Hon får aldrig en riktig karl'

mus2:
'Öh, öh jag kommer nu'
        
andramöss:     
'Nej, vi ska pippa'

Vi ska nuppa vi ska pippa
Allas könshår ska vi klippa
För den stora horarkvällen
Ska hon bli porrmodellen
Vi piercar hennes tuttar
och rakar hennes mutta
och horungen på bal
bland penisar i hundratal
hon suger kuken och blir knullad upp i pruttan

En mus ger kuken ståfräs
Den blir stadig då
la la lalalala la
och anuset bleks av en sol",
			"Trivia: Styrelsespex 2008"
			));

		songs.Add(new Song(
			"Tidelag",
			"Melodi: Djingis Khan med gruppen Djingis Khan",
			"Text: Åhlen",
			@"Den stackars lille mården är den siste kvar... av sitt slag HA HU HA!
Den enda jungfru här på gården han väntar på... tidelag HA HU

HA!
Måsen har blitt påsatt
giraffen han med
De stora starka djuren stod alla på led
När bonden kom där med sin stora feta HU HA HU!

Tid-tid-tidelag
han bräker, hon bräker vi bräker alla bräker
tid-tid-tidelag
Den råmar ni råmar jag råmar alla råmar
Stackars lilla geten HAHAHAHA!
Fick smaka på en fet en HOHOHOHO!
När bonden kom där med sin långa lena

Tid-tid-tidelag
han bräker, hon bräker vi bräker alla bräker
tid-tid-tidelag
Den råmar ni råmar jag råmar alla råmar
Räven den kanaljen HAHAHAHA!
Fick smeka han på ballen HOHOHOHO!
När bonden kom där med sin fina heta

Den stackars store bonden har haft allting han, på sin gård HA HU HA
Från stora feta oxar till det sista djur, en feg mård HA HU HA
Nu är han trött på zoofasoner
ja riktigt utled
och alla kåta djuren står ännu på led
Men bonden får ej upp sin stora feta HU HA HU!

Refr: Tid-tid-tidelag...",
			"Trivia: Dammiddag 2009"
			));

		songs.Add(new Song(
			"Jag vill ha samlag",
			"Melodi: Man ska ha husvagn",
			"Text: Åhlen",
			@"Jag har knullat nästan allt som finns att sätta på
känt mig rätt så tuff och liksom bara festat å
men nu känns det som något saknas i mitt hem
nu vill jag ha barn som kommit ur min egna lem

Jag vill ha samlag
men inte ha någon kondom
Jag vill ha samlag
det finns nog risk för kondylom
Jag vill ha samlag
för det är så små barn blir till
Jag vill ha samlag
hoppas att du vill

I många år så var jag inte överdrivet mogen
jag rulla gärna runt med alla jäntorna i logen
men så en dag sa jag till frugan vänligt men bestämt
nu särar du på benen för nu ska vi två bli fem

Vi ska ha samlag
nu är det dags att bli gravid
Vi ska ha samlag
nu gör vi sex med all vår tid (??) (“nu har vi sex mest hela ti¨n”?)
Vi ska ha samlag
nu ska du få min barnajuice
Vi ska ha samlag
dags för dagens dos

5 minuter vaginalt och 5 minuter runka
5 minuter med oralt och 5 minuter plunka
5 minuter i anal och 5 minuter hem
5 minuter till så ska jag spruta med min lem

Jag vill ha samlag
men inte ha någon kondom
Jag vill ha samlag
det finns nog risk för kondylom
Jag vill ha samlag
för det är så små barn blir till
Jag vill ha samlag
hoppas att du vill",
			""
			));

		songs.Add(new Song(
			"Saltkodarn",
			"Melodi: Saltkråkan",
			"Text: Åhlen",
			@"Jag skulle koda mig en liten app häromdan
Jag skulle koda mig en liten app häromdan
i Cobol, C och Fortran
Cobol, C och Fortran
språken som är äldre än vad farsan är

Jag skulle hitta mig en liten bugg häromdan
Jag skulle hitta mig en liten bugg häromdan
input kom i output
input kom i output
minnesläcka och jag fick ett segment fault

Jag skulle bygga på ett riktigt saftigt system
Jag skulle bygga på ett riktigt saftigt system
Känn den kompilera
känn den kompilera
datorn brölar, GCC är jävligt kåt   <3

Oh, java java, java java java java
Java java, java java java java
C++ är python
C++ är python
ruby, den kan, kyssa min kanelrubin

å se på perl hon är en liten hora, javisst
se på perl hon är en liten hora, javisst
tar den upp i snigeln
tar den upp i snigeln
viker ut sig, överallt på internet",
			""
			));

        return songs;
    }
}