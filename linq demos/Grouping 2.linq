<Query Kind="Expression">
  <Connection>
    <ID>89b5626c-3013-49b1-b44e-30b91b389f87</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from food in Items
group food by new {food.MenuCategoryID}
// no need for the select command if all you want is grouping