import React, { useState } from "react";
import ItemContainer from "./ItemContainer";

const Item = props => {
  const { name, choices, related } = props;
  const [showChoices, toggleShowChoices] = useState(false);
  const [itemChoices, changeItemChoices] = useState({});

  const handleInputChange = e => {
    changeItemChoices({ ...itemChoices, [e.target.name]: e.target.checked });
  };

  const checkRelatedStatus = () => {
    for (let key in itemChoices) {
      if (itemChoices[key] === true) {
        return true;
      }
    }
    return false;
  };

  return (
    <div>
      <input
        type="checkbox"
        name={name}
        value={name}
        id={name}
        onChange={() => toggleShowChoices(!showChoices)}
      />
      <label htmlFor={name}>{name}</label>
      {showChoices ? (
        <div className="choices">
          {choices.map(choice => {
            return (
              <div key={choice.name}>
                <input
                  type="checkbox"
                  name={choice.name}
                  value={choice.name}
                  id={choice.name}
                  onChange={handleInputChange}
                />
                <label htmlFor={choice.name}>{choice.name}</label>
              </div>
            );
          })}
        </div>
      ) : null}

      {related ? (
        <div className="choices">
          {showChoices && related.length > 0 && checkRelatedStatus() ? (
            <div>
              <p>You might also want: </p>
              <ItemContainer data={related} />
            </div>
          ) : null}
        </div>
      ) : null}
    </div>
  );
};

export default Item;
