# GestioneComande
## Utilizzo
Il programma è stato sviluppato in C# Windows forms.
Per il corretto funzionamento del programma è necessario avere:
- .NET Framework 4.8
- Sql server management 2019

Durante l'installazione se questi programmi non sono presenti verranno scaricati ed installati automaticamente.
Il progetto è stato sviluppato con il db Code First in modo da poter creare un db sulla macchina locale così da poter utilizzare il programma senza la necessità di
collegarsi ad internet.

## Scopo

L'idea dietro a questo programma è quella di poter gestire le "comande" ovvero le richieste di clienti (come in un ristorante).

## Descrizione
Il programma è stato diviso in "TAB" per permettere una facile navigazione da parte dell'utilizzatore.

### TAB "Configurazione"
Il programma permette di effettuare una fase di "Configurazione" dove è possibile impostare dei parametri secondo le proprie esigenze:
- Intestazione: il titolom che verrà stampato sulla "comanda" finale
- Numero di partenza delle comande: il numero che verrà preso in considerazione dalle successive comande create (il numero si incrementa ad ogni comanda creata)
- Serie: è possibile impostare la serie in modo da poter variare il numero di comanda finale o per gestire le comande con più macchine contemporaneamente.
- Operatore: l'operatore che andrà a gestire il programma e a creare le comande per i clienti che sarà visibile nella comanda finale.

### TAB "Crea piatto"
In questa TAB è possibile creare gli elementi che verranno poi gestiti durante la creazione della comanda. I parametri sono i seguenti:
- Nome: il nome da assegnare all'elemento
- Tipologia: è possibile scegliere da un menu a tendina tra 2 tipologie: piatto o bevanda.
- Quantità: impostare la quantità disponibile per l'elemento, la quantità verrà aggiornata ad ogni comanda creata.
- Costo: il costo del singolo elemento

### TAB "Lista piatti"
In questa TAB verrà mostrata una tabella con tutti gli elementi creati nella TAB "Crea piatto".
È possibile modificare gli elementi creati in precedenza, eliminarli ed impostarli come "Attivi":
- Click su "Attiva": se attivo l'elemento sarà visualizzato nella successiva TAB "Crea comanda" altrimenti non sarà visibile.
- Click su "Elimina": l'elemento verrà eliminato logicamente dal db per preservare lo storico delle comande create.
- Click su "Salva": permette di salvare eventuali modifiche effettuare su questa tab.

### TAB "Crea comanda"
In questa TAB verrà visualizzata una tabella con gli elementi creati in precedenza dove sarà possibile indicare la quantità desiderata.
Operazioni in questa TAB:
- Piatto: è possibile modificare il nome del piatto per aggiungere delle note (es. Pasta con pomodoro -> pasta con pomodoro [no formaggio]) che verranno 
mostrate sulla comanda finale 
- Quantità: impostare la quantità desiderata dell'elemento, una volta impostata verrà aggiornato il conteggio totale del costo. Impostando una quantità superiore a quella 
disponibile il programma restituirà un errore.
- Nominativo: impostare il nominatico del cliente, verrà poi mostrato nella comanda finale.
- Pagato: impostare la cifra versata dal cliente, verrà poi calcolato il "resto" in base al costo totale e alla cifra versata.

Funzionalità "Stampa" al click andrà ad effettuare le seguenti operazioni:
- Creazione sul db della comanda
- Aggiornamento numero della comanda
- Aggiornamento quantità restanti degli elementi acquistati


### TAB "Visualizza comande"
In questa TAB verrà mostrata una tabella con le comande evase con la possibilità di stampare nuovamente la comanda.
È possibile impostare una data di inizio ed una data di fine per visualizzare le comande in quel lasso di tempo cliccando sul pulsante "Cerca".
Con il pulsante "Esporta file excel" andrà ad aprire il programma predefinito sulla macchina per la gestione dei file xls con la tabella delle comande
copiata

### TAB "Statistiche"
In questa TAB verrà mostrata una tabella con le statistiche degli elementi creati ovvero:
- Nome dell'elemento
- Quantità totale
- Quantità rimasta
- Quantità venduta
- Guadagno
Con il pulsante "Esporta excel" andrà ad aprire il programma predefinito sulla macchina per la gestione dei file xls con la tabella delle statistiche copiata
