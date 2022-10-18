class Library
{
    private List<string> library = new List<string>
    {
        "Actor",
        "Advertisement",
        "Afternoon",
        "Airport",
        "Ambulance",
        "Animal",
        "Answer",
        "Apple",
        "Army",
        "Australia",
        "Balloon",
        "Banana",
        "Battery",
        "Beach",
        "Beard",
        "Bead",
        "Belgium",
        "Boy",
        "Branch",
        "Breakfast",
        "Brother",
        "Camera",
        "Candle",
        "Car",
        "Caravan",
        "Carpet",
        "Cartoon",
        "China",
        "Church",
        "Crayon",
        "Crowd",
        "Daughter",
        "Death",
        "Denmark",
        "Diamond",
        "Dinner",
        "Disease",
        "Doctor",
        "Dog",
        "Dream",
        "Dress",
        "Easter",
        "Egg",
        "Eggplant",
        "Egypt",
        "Elephant",
        "Energy",
        "Engine",
        "England",
        "Evening",
        "Eye",
        "Family",
        "Finland",
        "Fish",
        "Flag",
        "Flower",
        "Football",
        "Forest",
        "Fountain",
        "France",
        "Furniture",
        "Garage",
        "Gas",
        "Garden",
        "Girl",
        "Glass",
        "Ghost",
        "Gold",
        "Grass",
        "Greece",
        "Guitar",
        "Hair",
        "Hamburger",
        "Helicopter",
        "Helmet",
        "Holiday",
        "House",
        "Hydrogen",
        "Ice",
        "Insect",
        "Insurance",
        "Iron",
        "Island",
        "Jackal",
        "Jelly",
        "Jewellery",
        "Jordan",
        "Juice",
        "Kangaroo",
        "King",
        "Kitchen",
        "Kite",
        "Knife",
        "Lamp",
        "Lawyer",
        "Leather",
        "Library",
        "Lighter",
        "Lion",
        "Lizard",
        "Lock",
        "London",
        "Lunch",
        "Machine",
        "Magazine",
        "Magician",
        "Manchester",
        "Market",
        "Match",
        "Microphone",
        "Monkey",
        "Morning",
        "Motorcycle",
        "Nail",
        "Napkin",
        "Needle",
        "Nest",
        "Nigeria",
        "Night",
        "Notebook",
        "Ocean",
        "Oil",
        "Orange",
        "Oxygen",
        "Oyster",
        "Painting",
        "Parrot",
        "Pencil",
        "Piano",
        "Pillow",
        "Pizza",
        "Planet",
        "Plastic",
        "Portugal",
        "Potato",
        "Queen",
        "Quill",
        "Rain",
        "Rainbow",
        "Raincoat",
        "Refrigerator",
        "Trestaurant",
        "River",
        "Rocket",
        "Room",
        "Rose",
        "Russia",
        "Sandwich",
        "School",
        "Scooter",
        "Shampoo",
        "Shoe",
        "Soccer",
        "Spoon",
        "Stone",
        "Sugar",
        "Sweden",
        "Teacher",
        "Telephone",
        "Television",
        "Tent",
        "Thailand",
        "Tomato",
        "Toothbrush",
        "Traffic",
        "Train",
        "Truch",
        "Uganda",
        "Umbrella",
        "Van",
        "Vase",
        "Vegetable",
        "Vulture",
        "Wall",
        "Whale",
        "Window",
        "Wire",
        "Xylophone",
        "Yacht",
        "Yak",
        "Zebra",
        "Zoo"
    };

    private string randomWord(List<string> library)
    {
        var rand = new Random();
        string word = library[rand.Next(library.Count)];
        return word;
    }

    public string getWord(string difficulty) // Difficulty requires a string of either "easy", "medium", or "hard"
    {
        string word = "";
        if (difficulty == "easy")
        {
            while (word == "")
            {
                string word0 = randomWord(library);
                if (word0.Length < 5)
                {
                    word = word0;
                }
                else
                {
                    word = "";
                }
            }
        }
        else if (difficulty == "medium")
        {
            while (word == "")
            {
                string word0 = randomWord(library);
                if (5 <= word0.Length && word0.Length < 7)
                {
                    word = word0;
                }
                else
                {
                    word = "";
                }
            }
        }
        else if (difficulty == "hard")
        {
            while (word == "")
            {
                string word0 = randomWord(library);
                if (7 <= word0.Length)
                {
                    word = word0;
                }
                else
                {
                    word = "";
                }
            }
        }
        return word;
    }
}