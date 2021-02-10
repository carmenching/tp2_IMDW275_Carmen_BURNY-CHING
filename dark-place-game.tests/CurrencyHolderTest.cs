using System;
using Xunit;

namespace dark_place_game.tests
{
    
    /// Cette classe contient tout un ensemble de tests unitaires pour la classe CurrencyHolder
    public class CurrencyHolderTest
    {
        public static readonly int EXEMPLE_CAPACITE_VALIDE = 2748;
        public static readonly int EXEMPLE_CONTENANCE_INITIALE_VALIDE = 978;
        public static readonly string EXEMPLE_NOM_MONNAIE_VALIDE = "Brouzouf";

        //[Fact]
        //public void VraiShouldBeTrue()
        //{
        //    var vrai = true;
        //    Assert.True(vrai, "Erreur, vrai vaut false. Le test est volontairement mal écrit, corrigez le.");
        //}

        //[Fact]
        //public void CurrencyHolderCreatedWithInitialCurrentAmountOf10ShouldContain10Currency()
        //{
        //    var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 10);
        //    var result = ch.CurrentAmount == 10;
        //    Assert.True(result);
        //}

        //[Fact]
        //public void CurrencyHolderCreatedWithInitialCurrentAmountOf25ShouldContain25Currency()
        //{
        //    var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 25);
        //    var result = ch.CurrentAmount == 25;
        //    Assert.True(result);
        //}

        //[Fact]
        //public void CurrencyHolderCreatedWithInitialCurrentAmountOf0ShouldContain0Currency()
        //{
        //    var ch = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 0);
        //    var result = ch.CurrentAmount == 0;
        //    Assert.True(result);
        //}

        //[Fact]
        //public void CreatingCurrencyHolderWithNegativeContentThrowExeption()
        //{
        //    // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un peu exotique : les expression lambda.
        //    // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger des tests unitaires elle devrais vous suffire.
        //    Action mauvaisAppel = () => new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, -10);
        //    Assert.Throws<CurrencyHolderArgumentsException>(mauvaisAppel);
        //}

        //[Fact]
        //public void CreatingCurrencyHolderWithNullNameThrowExeption()
        //{
        //    // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un peu exotique : les expression lambda.
        //    // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger des tests unitaires elle devrais vous suffire.
        //    Action mauvaisAppel = () => new CurrencyHolder(null, EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
        //    Assert.Throws<CurrencyHolderArgumentsException>(mauvaisAppel);
        //}

        //[Fact]
        //public void CreatingCurrencyHolderWithEmptyNameThrowExeption()
        //{
        //    // Petite subtilité : pour tester les levées d'exeption en c# on est obligé d'utiliser un concept un peu exotique : les expression lambda.
        //    // sans entrer dans le détail pour déclarer une lambda respectez la syntaxe ci dessous, pour rédiger des tests unitaires elle devrais vous suffire.
        //    Action mauvaisAppel = () => new CurrencyHolder("", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
        //    Assert.Throws<CurrencyHolderArgumentsException>(mauvaisAppel);
        //}

        ////#TODO_ETAPE_4
        //[Fact]
        //public void BrouzoufIsAValidCurrencyName()
        //{
        //    //A vous d'écrire un test qui vérife qu'on peut créer un CurrencyHolder contenant une monnaie dont le nom est Brouzouf
        //    CurrencyHolder currencyHolderTest = new CurrencyHolder("Brouzouf", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
        //    Assert.Equal("Brouzouf", currencyHolderTest.CurrencyName);
        //}

        //[Fact]
        //public void DollardIsAValidCurrencyName()
        //{
        //    // A vous d'écrire un test qui vérife qu'on peut créer un CurrencyHolder contenant une monnaie dont le nom est Dollard
        //    CurrencyHolder currencyHolderTest = new CurrencyHolder("Dollard", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
        //    Assert.Equal("Dollard", currencyHolderTest.CurrencyName);
        //}

        //[Fact]
        //public void TestPut10CurrencyInNonFullCurrencyHolder()
        //{
        //    // A vous d'écrire un test qui vérifie que si on ajoute via la methode put 10 currency à un sac a moité plein, il contient maintenant la bonne quantité de currency
        //    // Tester avec un nombre aléatoire - Un currency initié avec 1360 comme capacité valide, et une contenance initiale à 680, donc la moitié du sac. 
        //    CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, 1360, 680);
        //    currencyHolderTest.Store(10);
        //    Assert.True(currencyHolderTest.CurrentAmount == 690);
        //}

        //[Fact]
        //public void TestPut10CurrencyInNearlyFullCurrencyHolder()
        //{
        //    // A vous d'écrire un test qui vérifie que si on ajoute via la methode put 10 currency à un sac quasiement plein, une exeption NotEnoughtSpaceInCurrencyHolderExeption est levée.
        //    CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, 2747);
        //    Action mauvaisAppel = () => currencyHolderTest.Store(10);
        //    Assert.Throws<CapacityReachedException>(mauvaisAppel);
        //}

        //[Fact]
        //public void CreatingCurrencyHolderWithNameShorterThan4CharacterThrowExeption()
        //{
        //    // A vous d'écrire un test qui doit échouer s'il es possible de créer un CurrencyHolder dont Le Nom De monnaie est inférieur a 4 lettres
        //    Action mauvaisAppel = () => new CurrencyHolder("abc", EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
        //    Assert.Throws<CurrencyHolderArgumentsException>(mauvaisAppel);
        //}

        //[Fact]
        //public void WithdrawMoreThanCurrentAmountInCurrencyHolderThrowExeption()
        //{
        //    // A vous d'écrire un test qui vérifie que retirer (methode withdraw) une quantité negative de currency leve une exeption CantWithDrawNegativeCurrencyAmountExeption.
        //    // Astuce : dans ce cas prévu avant même de pouvoir compiler le test, vous allez être obligé de créer la classe CantWithDrawMoreThanCurrentAmountExeption 
        //    // (vous pouvez la mettre dans le meme fichier que CurrencyHolder)
        //    CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
        //    Assert.Throws<CantWithDrawMoreThanCurrentAmountExeption>(() => currencyHolderTest.Withdraw(980));


        //}
        //#TODO_ETAPE_4 

        //#ETAPE 6
        [Fact]
        public void CurrencyNameWith12CharactersThrowException()
        {
            Action mauvaisAppel = () => new CurrencyHolder("dslkdrjewkle", EXEMPLE_CAPACITE_VALIDE,
                EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<CurrencyHolderArgumentsException>(mauvaisAppel);
        }

        [Fact]
        public void CurrencyNameBetween4CharactersAndMoreThan10CharactersDoesNotThrowException()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder("dslkd", EXEMPLE_CAPACITE_VALIDE,
                EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Equal("dslkd", currencyHolderTest.CurrencyName);
        }

        // On ne peux pas mettre (methode) put une quantité negative de currency dans un CurrencyHolder
        [Fact]
        public void StoreNegative15CurrencyAmountThrowException()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<StoreCurrencyArgumentsException>(() => currencyHolderTest.Store(-15));
        }

        [Fact]
        public void Store0CurrencyAmountThrowException()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<StoreCurrencyArgumentsException>(() => currencyHolderTest.Store(0));
        }

        [Fact]
        public void Withdraw0CurrencyAmountThrowException()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.Throws<WithdrawCurrencyArgumentsException>(() => currencyHolderTest.Withdraw(0));
        }

        [Fact]
        public void CreatingCurrencyWithNameStartingWithLowerCaseAThrowException()
        {
            Assert.Throws<CurrencyHolderArgumentsException>(() => new CurrencyHolder("abdce",
                EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE));
        }

        [Fact]
        public void CreatingCurrencyWithNameStartingWithUpperCaseAThrowException()
        {
            Assert.Throws<CurrencyHolderArgumentsException>(() => new CurrencyHolder("Abdce",
                EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE));
        }

        [Fact]
        public void CreatingCurrencyWith1CapacityIsValid()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, 1, 0);
            Assert.True(currencyHolderTest != null);
        }


        [Fact]
        public void CreatingCurrencyWith0CapacityThrowException()
        {
            Assert.Throws<CurrencyHolderArgumentsException>(() => new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE, 0, 0));
        }

        [Fact]
        public void CurrencyCreatedWithConstantQuantityCurrencyIsNotEmpty()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                EXEMPLE_CAPACITE_VALIDE, EXEMPLE_CONTENANCE_INITIALE_VALIDE);
            Assert.True(!currencyHolderTest.IsEmpty());
        }


        [Fact]
        public void CreatingCurrencyWith0CurrencyIsEmpty()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                EXEMPLE_CAPACITE_VALIDE, 0);
            Assert.True(currencyHolderTest.IsEmpty());
        }

        [Fact]
        public void CreatingCurrencyWithCurrencyEqualsToCapacityIsFull()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                2748, 2748);
            Assert.True(currencyHolderTest.IsFull());
        }

        [Fact]
        public void CreatingCurrencyWithCurrencyNotEqualsToCapacityIsNotFull()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                3000, 2748);
            Assert.False(currencyHolderTest.IsFull());
        }

        [Fact]
        public void CreatingCurrencyWithMaxCapacityAndMaxCurrencyIsFull()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                Int32.MaxValue, Int32.MaxValue);
            Assert.True(currencyHolderTest.IsFull());
        }
        [Fact]
        public void CreatingCurrencyWith100000Capacityand15000IsNotFull()
        {
            CurrencyHolder currencyHolderTest = new CurrencyHolder(EXEMPLE_NOM_MONNAIE_VALIDE,
                100000, 15000);
            Assert.False(currencyHolderTest.IsFull());
        }
    }
}
