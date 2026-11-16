using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int monedasActuales = 0;

    void Start()
    {
        // 1. Recogemos monedas
        SumarMonedas(50);

        // 2. Intentamos comprar un objeto que cuesta 30 monedas
        bool compraExitosa = IntentarComprar(30);

        if (compraExitosa)
        {
            Debug.Log("¡Objeto comprado con éxito!");
        }
        else
        {
            Debug.Log("No tienes suficientes monedas.");
        }
    }

    // FUNCIÓN 1: Suma una cantidad al total (no devuelve nada)
    public void SumarMonedas(int cantidad)
    {
        monedasActuales += cantidad;
        Debug.Log("Monedas totales: " + monedasActuales);
    }

    // FUNCIÓN 2: Comprueba saldo, descuenta y devuelve si la compra fue posible (bool)
    public bool IntentarComprar(int precio)
    {
        if (monedasActuales >= precio)
        {
            monedasActuales -= precio;
            return true;  // Compra completada
        }

        return false;     // Fondos insuficientes
    }
}