
function fadeOut(selectors) {

	var opacity = 1;

	var timer = setInterval(function () {

		if (opacity <= 0.1) {

			clearInterval(timer);
			document.querySelector(selectors).style.display = "none";

		}

		document.querySelector(selectors).style.opacity = opacity;

		opacity -= 0.1;

	}, 5);
}

function fadeOutWithDelay(selectors, ms) {
	setTimeout(() => fadeOut(selectors), ms);
}


function fadeIn(selectors) {

	var opacity = 0.01;

	document.querySelector(selectors).style.display = "block";

	var timer = setInterval(function () {

		if (opacity >= 1) {

			clearInterval(timer);

		}

		document.querySelector(selectors).style.opacity = opacity;

		opacity += 0.1;

	}, 5);
}



