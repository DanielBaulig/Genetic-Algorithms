using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticAlgorithms;
using GeneticAlgorithms.Example_Classes;
using System.Collections;

namespace GeneticAlgorithmsTest
{

    /// <summary>
    /// Zusammenfassungsbeschreibung für UnitTest1
    /// </summary>
    [TestClass]
    public class GeneticAlgorithmsTest
    {
        public GeneticAlgorithmsTest()
        {
            //
            // TODO: Konstruktorlogik hier hinzufügen
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Textkontext mit Informationen über
        ///den aktuellen Testlauf sowie Funktionalität für diesen auf oder legt diese fest.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Zusätzliche Testattribute
        //
        // Sie können beim Schreiben der Tests folgende zusätzliche Attribute verwenden:
        //
        // Verwenden Sie ClassInitialize, um vor Ausführung des ersten Tests in der Klasse Code auszuführen.
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Verwenden Sie ClassCleanup, um nach Ausführung aller Tests in einer Klasse Code auszuführen.
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen. 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestBoolGene()
        {
            
            BoolGene gene = new BoolGene();
            gene = true;
            Assert.AreEqual(true, (Boolean) gene);
            Assert.AreNotEqual(false, (Boolean)gene);

            gene = false;
            Assert.AreEqual(false, (Boolean)gene);
            Assert.AreNotEqual(true, (Boolean)gene);
            if (false != gene)
                Assert.Fail("Implicit typecast not functioning");

            BoolGene anotherGene = gene;
            Assert.AreEqual(false, (Boolean)anotherGene);
            Assert.AreNotEqual(true, (Boolean)anotherGene);

            gene = true;
            Assert.AreEqual(false, (Boolean)anotherGene);
            Assert.AreNotEqual(true, (Boolean)anotherGene);


            gene.Mutate();
        }

        [TestMethod]
        public void TestAsymmetricZipRecombinator()
        {
            Chromosome<BoolGene> father = new Chromosome<BoolGene>(2);
            Chromosome<BoolGene> mother = new Chromosome<BoolGene>(2);
            IRecombinationProvider recombinator = new AsymmetricZipRecombinator();

            father[0] = true;
            father[1] = false;
            mother[0] = false;
            mother[1] = true;

            Chromosome<BoolGene> child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child.GeneCount == 2);
            Assert.IsTrue(child[0] == false && child[1] == false, "Fix recombination not correct!");

            father[0].Mutate();
            mother[1].Mutate();

            child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child[0].Equals(mother[0]) && child[1].Equals(father[1]), "Variable recombination not correct!");

            father = new Chromosome<BoolGene>(3);
            mother = new Chromosome<BoolGene>(5);

            father[0] = true;
            father[1] = false;
            father[2] = true;
            mother[0] = false;
            mother[1] = true;
            mother[2] = false;
            mother[3] = true;
            mother[4] = false;

            child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child.GeneCount == 5, "Gene Count wrong in asymmeric test");
            Assert.IsTrue(child[0] == true && child[1] == true && child[2] == true && child[3] == true && child[4] == false, "Fix recombination in asymetric Mother/Father not correct!");
        }

        [TestMethod]
        public void TestBoolChromosome()
        {
            Chromosome<BoolGene> chromosome = new Chromosome<BoolGene>(2);

            Assert.AreEqual(2, chromosome.GeneCount);
            chromosome[0] = true;
            Assert.AreEqual(true, (Boolean)chromosome[0]);
            if (true != chromosome[0])
                Assert.Fail("Implicit typecast not functioning");

            chromosome[0].Mutate();
        }

        [TestMethod]
        public void TestCrossoverRecombinator()
        {
            Chromosome<BoolGene> father = new Chromosome<BoolGene>(2);
            Chromosome<BoolGene> mother = new Chromosome<BoolGene>(2);
            IRecombinationProvider recombinator = new CrossoverRecombinator();

            father[0] = true;
            father[1] = false;
            mother[0] = false;
            mother[1] = true;

            Chromosome<BoolGene> child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child[0] == true && child[1] == true, "Fix recombination not correct!");

            // Following only functional with inverting Mutation! 
            father[0].Mutate();
            Assert.IsFalse(father[0]);
            father[0].Mutate();
            Assert.IsTrue(father[0]);
            mother[1].Mutate();

            child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child[0].Equals(father[0]) && child[1].Equals(mother[1]), "Variable recombination not correct!");
         }
        private bool delegateRun = false;
        private int delegateRunCount = 0;
        private GeneticSimulation<BoolGene> simulation;
        private void TestDelegate(object sender, EventArgs e)
        {
            delegateRun = true;
            delegateRunCount++;
        }

        [TestMethod]
        public void TestGeneticSimulation()
        {
            simulation = new GeneticSimulation<BoolGene>(100, 5, new BoolGrowthLimitedFitness(), new AsymmetricCrossoverRecombinator(), new AlphaSelector() ,new PieCakeSelector());
            //simulation.GeneDuplicationRate = 0.00001;
            simulation.SimulationTurn += new OnSimulationTurn(TestDelegate);
            simulation.RunSimulation();

            Assert.IsTrue(delegateRun);

            delegateRunCount = 0;
            simulation.RunSimulation(1000);
            
            Assert.AreEqual(1000, delegateRunCount, "Did not run 1000 times!");

           /* Assert.AreEqual(5.0, simulation.AverageFitness, 0.5, "This may occur, rerun Test and see if it keeps happening!");
            Assert.AreEqual(5.0, simulation.MostSuccessfullIndividual.Fitness, "This may occur, rerun Test and see if it keeps happening!");*/

            simulation.ResetSimulation();
            delegateRunCount = 0;
            delegateRun = false;
            simulation.GeneDuplicationRate = 0.01;

            simulation.RunSimulation();

            Assert.IsTrue(delegateRun);

            delegateRunCount = 0;
            simulation.RunSimulation(10);

        /*    Assert.AreEqual(10, delegateRunCount, "Did not run 10 times!");
            Assert.IsTrue(simulation.AverageChromosomeLength > 5, "Average Chromosome Lengtrh not > 5");                */
        }

        [TestMethod]
        public void TestAsymetricCrossoverRecombinator()
        {
            Chromosome<BoolGene> father = new Chromosome<BoolGene>(2);
            Chromosome<BoolGene> mother = new Chromosome<BoolGene>(2);
            IRecombinationProvider recombinator = new AsymmetricCrossoverRecombinator();

            father[0] = true;
            father[1] = false;
            mother[0] = false;
            mother[1] = true;

            Chromosome<BoolGene> child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child.GeneCount == 2);
            Assert.IsTrue(child[0] == true && child[1] == true, "Fix recombination not correct!");

            father[0].Mutate();
            mother[1].Mutate();

            child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child[0].Equals(father[0]) && child[1].Equals(mother[1]), "Variable recombination not correct!");

            father = new Chromosome<BoolGene>(3);
            mother = new Chromosome<BoolGene>(5);

            father[0] = true;//child 0
            father[1] = false;//child 1
            father[2] = true;
            mother[0] = false;
            mother[1] = true;
            mother[2] = false;
            mother[3] = true; //child 2
            mother[4] = false; // child 3

            child = father.Recombine(mother, recombinator);
            Assert.IsTrue(child.GeneCount == 4);
            Assert.IsTrue(child[0] == true && child[1] == false && child[2] == true && child[3] == false, "Fix recombination in asymetric Mother/Father not correct!");
        }

        [TestMethod]
        public void TestBoolSumFitness()
        {
            Chromosome<BoolGene> chromosome = new Chromosome<BoolGene>(5);
            IFitnessFunctionProvider fitnessFunction = new BoolSumFitness();

            chromosome[0] = true;
            chromosome[1] = true;
            chromosome[2] = true;
            chromosome[3] = true;
            chromosome[4] = true;

            chromosome.computeFitness(fitnessFunction);

            Assert.AreEqual(5.0f, chromosome.Fitness);

            chromosome[2] = false;
            chromosome[3] = false;

            chromosome.computeFitness(fitnessFunction);

            Assert.AreEqual(3.0f, chromosome.Fitness);
        }

        [TestMethod]
        [ExpectedException(typeof(GenesIncompatibleException))]
        public void TestCrossoverRecombinatorException()
        {
            Chromosome<BoolGene> chrom1 = new Chromosome<BoolGene>(1);
            Chromosome<BoolGene> chrom2 = new Chromosome<BoolGene>(2);
            IRecombinationProvider recom = new CrossoverRecombinator();
            Chromosome<BoolGene> newChrom = chrom1.Recombine(chrom2, recom);
        }

        [TestMethod]
        public void TestRaumschiff()
        {
            ArrayList kommandos = new ArrayList(0);
            Raumfahrer pilot = new Raumfahrer(kommandos);
            Raumschiff schiff = new Raumschiff(pilot, 100, 100, 100);

            Assert.AreEqual(100, schiff.Treibstoff);
            Assert.AreEqual(100, schiff.Hoehe);
            Assert.AreEqual(100, schiff.Gewicht);
        }

        [TestMethod]
        public void TestRaumfahrer()
        {
            ArrayList kommandos = new ArrayList(10);
            for (int i = 0; i < 10; i++)
                kommandos.Add(new IntGene(1));

            Raumfahrer pilot = new Raumfahrer(kommandos);
            Assert.AreEqual(10, pilot.Gewicht);
            Raumschiff schiff = new Raumschiff(pilot, 100, 100, 1);
            pilot.SteuereRaumschiff(schiff);
            Assert.AreEqual(100-1, schiff.Treibstoff);
            Assert.AreEqual(1, schiff.Geschwindigkeit);
            pilot.SteuereRaumschiff(schiff);
            Assert.AreEqual(100 - 2, schiff.Treibstoff);
            Assert.AreEqual(2, schiff.Geschwindigkeit);

        }

        [TestMethod]
        public void TestMondlandungsSimulation()
        {
            ArrayList kommandos = new ArrayList(10);
            for (int i = 0; i < 10; i++)
                kommandos.Add(new IntGene(1));
                
            MondlandungsSimulation sim = new MondlandungsSimulation(100, 100, 1);
            
            Assert.AreEqual(10, sim.TestComputeFitness(kommandos));

        }

    }
}
