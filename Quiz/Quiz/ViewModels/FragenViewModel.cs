using System.Collections.Generic;

namespace Quiz
{
    class FragenViewModel
    {
        public static FragenModel[] quizcollection = new FragenModel[10];
        public static void Update()
        {
            quizcollection[0] = new FragenModel(
                "1",
                "Wie kann ich meinen Verkaufspreis ermitteln?",
                "Marktbeobachtung, Kundenbefragung, Kalkulation",
                "Schätzen",
                "Messen, Wiegen",
                "Würfeln",
                "Marktbeobachtung, Kundenbefragung, Kalkulation"
            );
            quizcollection[1] = new FragenModel(
                "2",
                "Was zählt nicht zu den variablen Kosten?",
                "Miete",
                "Materialkosten",
                "Frachtkosten",
                "Strom für die Maschinen",
                "Miete"
            );
            quizcollection[2] = new FragenModel(
                "3",
                "Was zählt nicht zu den fixen Kosten?",
                "Materialkosten",
                "Miete",
                "Gehälter für die Mitarbeiter",
                "Strom für die Büroräume",
                "Materialkosten"
            );
            quizcollection[3] = new FragenModel(
                "4",
                "Der Deckungsbeitrag ist der Teil des Verkaufspreises, der über den _____________ liegt.",
                "Stückkosten",
                "variablen Kosten",
                "Fixkosten",
                "Mietkosten",
                "Stückkosten"
            );
            quizcollection[4] = new FragenModel(
                "5",
                "variable Kosten ________________.",
                "verändern sich mit der produzierten Produktmenge",
                "fallen immer an, egal wie viel produziert wird",
                "sind für die Gewinn- und Verlustrechnung nicht relevant",
                "sind fix",
                "verändern sich mit der produzierten Produktmenge"
            );
            quizcollection[5] = new FragenModel(
                "6",
                "fixe Kosten ________________.",
                "fallen immer an, egal wie viel produziert wird",
                "sind für die Gewinn- und Verlustrechnung nicht relevant",
                "sind variabel",
                "verändern sich mit der produzierten Produktmenge",
                "fallen immer an, egal wie viel produziert wird"
            );
            quizcollection[6] = new FragenModel(
                "7",
                "Wie wird der Gesamtumsatz für das gesamte Jahr berechnet?",
                "Verkaufspreis pro Stück * Anzahl verkaufte Produkte",
                "Fixkosten * Anzahl verkaufte Produkte",
                "Miete * variable Kosten",
                "variable Kosten pro Stück * Anzahl verkaufte Produkte",
                "Verkaufspreis pro Stück * Anzahl verkaufte Produkte"
            );
            quizcollection[7] = new FragenModel(
                "8",
                "Wie werden die variablen Kosten für das gesamte Jahr berechnet?",
                "variable Kosten pro Stück * Anzahl verkaufte Produkte",
                "Miete * Fixkosten",
                "Fixkosten- Deckungsbeitrag",
                "Deckungsbeitrag - Fixkosten",
                "variable Kosten pro Stück * Anzahl verkaufte Produkte"
            );
            quizcollection[8] = new FragenModel(
                "9",
                "Wie wird der Deckungsbeitrag für das gesamte Jahr berechnet?",
                "Verkaufspreis – variable Kosten",
                "Miete – Fixkosten",
                "Variable Kosten – Fixkosten",
                "Verkaufspreis pro Stück * Anzahl verkaufte Produkte",
                "Verkaufspreis – variable Kosten"
            );
            quizcollection[9] = new FragenModel(
                "10",
                "Wie wird der Gewinn/Verlust für das gesamte Jahr berechnet?",
                "Deckungsbeitrag für das gesamte Jahr – Fixkosten",
                "Miete * Fixkosten",
                "variable Kosten pro Stück * Anzahl verkaufte Produkte",
                "Verkaufspreis – variable Kosten",
                "Deckungsbeitrag für das gesamte Jahr – Fixkosten"
            );
        }

    }
}
