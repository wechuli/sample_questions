const data = [
  {
    name: "Salad",
    choices: [
      {
        name: "Santa Fe"
      },
      {
        name: "Greek"
      },
      {
        name: "Asian"
      }
    ],
    related: [
      {
        name: "Dressing",
        choices: [
          {
            name: "italian"
          },
          {
            name: "Blue Cheese"
          },
          {
            name: "Ranch"
          }
        ]
      },
      {
        name: "Bread",
        choices: [
          {
            name: "italian"
          },
          {
            name: "Flat"
          },
          {
            name: "Sourdough"
          }
        ]
      }
    ]
  },
  {
    name: "Entree",
    choices: [
      {
        name: "Steak"
      },
      {
        name: "Salmon"
      },
      {
        name: "Rice"
      }
    ],
    related: []
  },
  {
    name: "Soup",
    choices: [
      {
        name: "Minestrone"
      },
      {
        name: "Hot and sour"
      },
      {
        name: "Miso"
      }
    ],
    related: [{ name: "bread", choices: [{ name: "breadsticks" }] }]
  }
];

export default data;
