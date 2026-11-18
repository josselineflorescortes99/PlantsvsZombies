using UnityEngine;
 
public class CardsManager : MonoBehaviour
{
    [SerializeField]
    private Transform cardsBar;
    public void SetCards(PlantCardData[] plantCards)
    {
        foreach (PlantCardData plantCard in plantCards)
        {
            GameObject card = PoolManager.Instance.GetObject(plantCard.cardPrefab, cardsBar.position);
            card.transform.SetParent(cardsBar);
        }
    }
}
 