const express = require('express');
const app = express();

app.use(express.json());

const pedidos = [
    {idPedido: 1, nombreProducto: 'Laptop Lenovo Idepad', precioProducto: 799.99, estadoDisponibilidadProducto: true},
    {idPedido: 2, nombreProducto: 'Mouse Havit Gamer', precioProducto: 29.99, estadoDisponibilidadProducto: true},
    {idPedido: 3, nombreProducto: 'Teclado Mecanico Iziva', precioProducto: 34.99, estadoDisponibilidadProducto: false},
    {idPedido: 4, nombreProducto: 'Wacom Intous S', precioProducto: 44.99, estadoDisponibilidadProducto: true},
    {idPedido: 5, nombreProducto: 'Headphone Onikuma Gaming', precioProducto: 28.99, estadoDisponibilidadProducto: false},
]

app.get('/', (req, res) => {
    res.send('Accediendo a Gestion de Pedidos API');
});

app.get('/api/pedidos', (req, res) => {
    res.send(pedidos);
});

app.get('/api/pedidos/:idPedido', (req, res) => {
    const pedido = pedidos.find(c => c.idPedido === parseInt(req.params.idPedido));
    if (!pedido) return res.status(404).send('Pedido no encontrado');
    else res.send(pedido);
});

app.post('/api/pedidos', (req, res) => {
    const pedido = {
        idPedido: pedidos.length + 1,
        nombreProducto: req.body.nombreProducto,
        precioProducto: parseFloat(req.body.precioProducto),
        estadoDisponibilidadProducto: (req.body.estadoDisponibilidadProducto === 'true')
    };

    pedidos.push(pedido);
    res.send(pedido);
});

app.delete('/api/pedidos/:idPedido', (req, res) => {
    const pedido = pedidos.find(c => c.idPedido === parseInt(req.params.idPedido));
    if (!pedido) return res.status(404).send('Pedido no encontrado');

    const index = pedidos.indexOf(pedido);
    pedidos.splice(index, 1);
    res.send(pedido);
});

const puerto = process.env.puerto || 80;
app.listen(puerto, () => console.log(`Escuchando desde el puerto ${puerto}...`));


