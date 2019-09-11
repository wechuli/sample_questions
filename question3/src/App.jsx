import React from "react";
import data from "./data";
import ItemContainer from "./components/ItemContainer";

function App() {
  return (
    <>
      <div className="container">
        <h2>Restaurant Menu</h2>
        <ItemContainer data={data}/>
      </div>
    </>
  );
}

export default App;
