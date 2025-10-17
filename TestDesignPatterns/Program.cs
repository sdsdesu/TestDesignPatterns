// See https://aka.ms/new-console-template for more information
using TestDesignPatterns.Model;

var eiland = new Eiland();
eiland.Inwoners = TextAdaptor.LeesInwoners("TextFiles/Inwoners.txt");


eiland.GeefInwonersWeer();
eiland.Vulkaanuibarsting();