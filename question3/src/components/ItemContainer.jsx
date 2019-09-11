import React from "react";
import Item from "./Item";

const ItemContainer = props => {
  const { data } = props;
  return (
    <div>
      {data.map(item => {
        return <Item key={item.name} {...item} />;
      })}
    </div>
  );
};

export default ItemContainer;
