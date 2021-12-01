declare var game: any;

window.addEventListener('score', (ev: CustomEvent) => {
    document.querySelector('#score').textContent = ev.detail.score;
});

document.querySelector('#update-name').addEventListener('click', (ev: Event) => {
    game.SendMessage('PlayerUI', 'SetPlayerName', 'Player 1');
});
