document.addEventListener("DOMContentLoaded", () => {
    const form = document.getElementById('loginForm');

    if (!form) {
        console.error("❌ No se encontró el formulario con id 'loginForm'");
        return;
    }

    form.addEventListener('submit', async (e) => {
        e.preventDefault();
        console.log("🚀 Evento submit detectado"); // ← pon esto para confirmar

        const data = {
            email: document.getElementById('email').value,
            password: document.getElementById('password').value
        };

        try {
            await fetch('http://localhost:5023/api/Auth/login', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(data)
            });

            console.log("✅ Fetch ejecutado, reseteando form");
            form.reset();
        } catch (error) {
            console.error('❌ Error enviando los datos:', error);
        }
    });
});