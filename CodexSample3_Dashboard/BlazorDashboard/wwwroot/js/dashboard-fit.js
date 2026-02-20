const instances = new Map();

export function initDashboardFit(rootId, canvasId, baseWidth, baseHeight) {
    const root = document.getElementById(rootId);
    const canvas = document.getElementById(canvasId);
    if (!root || !canvas) {
        return;
    }

    const setFitMode = (enabled) => {
        root.classList.toggle("dashboard-fit-enabled", enabled);
        document.body.classList.toggle("dashboard-fit-lock", enabled);
    };

    const resize = () => {
        setFitMode(false);
        root.style.height = "";
        root.style.overflow = "auto";
        canvas.style.transform = "scale(1)";
    };

    const observer = new ResizeObserver(resize);
    observer.observe(canvas);

    const viewport = window.visualViewport;
    window.addEventListener("resize", resize);
    viewport?.addEventListener("resize", resize);
    resize();

    instances.set(rootId, { resize, viewport, observer });
}

export function disposeDashboardFit(rootId) {
    const current = instances.get(rootId);
    if (!current) {
        return;
    }

    window.removeEventListener("resize", current.resize);
    current.viewport?.removeEventListener("resize", current.resize);
    current.observer?.disconnect();
    instances.delete(rootId);

    if (instances.size === 0) {
        document.body.classList.remove("dashboard-fit-lock");
    }
}
