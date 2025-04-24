using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ochoball
{
    //el juego consta de :

    //hacerle preguntas (estas deben de ser de si o no)

    //de manera aleatoria entre las 20 respuestas te da una rta

    //las respuestas no se repiten

    public class Game
    {
        private string[] palabrasDeInicioPermitidas = 
        { "puedo","debo", "crees", "es", "tengo",
          "sería","habría","voy","estaré","debería"};

        private string[] answer = new string[]
        {
        "si",
        "Es cierto",
        "Es decididamente asi",
        "Sin lugar a dudas",
        "Sí, definitivamente",
        "Puedes confiar en ello",
        "Como yo lo veo, sí",
        "Lo más probable",
        "Perspectiva buena",
        "Las señales apuntan a que sí",
        "Respuesta confusa, vuelve a intentarlo",
        "Vuelve a preguntar más tarde",
        "Mejor no decirte ahora",
        "No se puede predecir ahora",
        "Concéntrate y vuelve a preguntar",
        "No cuentes con ello",
        "Mi respuesta es no",
        "Mis fuentes dicen que no",
        "Las perspectivas no son muy buenas",
        "Muy dudoso"
        };
        private List<string> repeated = new List<string>();

        private Boolean IsValidQuestion(String question)
        {
            string[] words = question.Split(" ");

            return palabrasDeInicioPermitidas.Contains(words[0]);
        }

        public string Play(string question)
        {

            if (IsValidQuestion(question) && CanContinuePlaying())
            {
                return GetAnswer();
            }

            throw new QuestionInvalidExeption("la pregunta no es valida");
        }

        private bool CanContinuePlaying()
        {
            return answer.Length!=repeated.Count;
        }

        private string GetAnswer()
        {
            var rnd = new Random();
            string getAnswer;

            do
            {
                int number = rnd.Next(answer.Length);
                getAnswer = answer[number];

            } while (repeated.Contains(getAnswer));

            repeated.Add(getAnswer);

            return getAnswer;
        }
    }
}
