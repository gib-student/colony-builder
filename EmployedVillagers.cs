using System;

namespace colony_builder
{
   public class EmployedVillagers
   {
      private int _employedOnFood;
      private int _employedOnWood;
      private int _employedOnStone;
      private int _unemployed;

      public EmployedVillagers()
      {
         _employedOnFood = Constants.FOOD_EMPLOYED_INITIAL_VALUE;
         _employedOnWood = Constants.WOOD_EMPLOYED_INITIAL_VALUE;
         _employedOnStone = Constants.STONE_EMPLOYED_INITIAL_VALUE;
         _unemployed = Constants.UNEMPLOYED_INITIAL_VALUE;
      }

      public int GetEmployedValue(string resource)
      {
         switch (resource)
         {
            case Constants.FOOD_ACTIONBAR_TEXT:
               return GetEmployedOnFood();
            case Constants.WOOD_ACTIONBAR_TEXT:
               return GetEmployedOnWood();
            case Constants.STONE_ACTIONBAR_TEXT:
               return GetEmployedOnStone();
            case Constants.UNEMPLOYED_TEXT:
               return GetUnemployed();
            default:
               return Constants.ERROR;
         }
      }

      public void SetEmployedOnFood(int employedOnFood)
      {
         _employedOnFood = employedOnFood;
      }

      public void IncrementEmployedOnFood()
      {
         _employedOnFood++;
      }

      public void DecrementEmployedOnFood()
      {
         _employedOnFood--;
      }

      public int GetEmployedOnFood()
      {
         return _employedOnFood;
      }

      public void SetEmployedOnWood(int employedOnWood)
      {
         _employedOnWood = employedOnWood;
      }

      public void IncrementEmployedOnWood()
      {
         _employedOnWood++;
      }

      public void DecrementEmployedOnWood()
      {
         _employedOnWood--;
      }

      public int GetEmployedOnWood()
      {
         return _employedOnWood;
      }

      public void SetEmployedOnStone(int employedOnStone)
      {
         _employedOnStone = employedOnStone;
      }

      public void IncrementEmployedOnStone()
      {
         _employedOnStone++;
      }

      public void DecrementEmployedOnStone()
      {
         _employedOnStone--;
      }

      public int GetEmployedOnStone()
      {
         return _employedOnStone;
      }

      public void SetUnemployed(int unemployed)
      {
         _unemployed= unemployed;
      }

      public void IncrementUnemployed()
      {
         _unemployed++;
      }

      public void DecrementUnemployed()
      {
         _unemployed--;
      }

      public int GetUnemployed()
      {
         return _unemployed;
      }
   }
}