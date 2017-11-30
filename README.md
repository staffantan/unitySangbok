# unitySangbok

Sångbok byggd i Unity

Kommer förprogrammerad med ett urval med studentikosa visor, och lite DISK klassiker. 
Baserad på DISK KMs sångbok.

Appen har stöd för att ställa in en serveradress att hämta fler sånger från, denna adress måste svara med en json fil med detta format:

```javascript
{
	"Items" : [
		{ 
			"Title":"Sångtitel",
			"Melody":"Namn på melodi",
			"Text":"Textförfattare",
			"Lyrics":"Sångtext",
			"Notes":"Trivia"
		},
		{ 
			"Title":"Sångtitel",
			"Melody":"Namn på melodi",
			"Text":"Textförfattare",
			"Lyrics":"Sångtext",
			"Notes":"Trivia"
		}
	]
}
```