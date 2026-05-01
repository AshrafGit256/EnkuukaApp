// ── ENKUUKA Y'OMWAKA — Site JS ──

// Nav scroll slim
const mainNav = document.getElementById('mainNav');
if (mainNav) {
    window.addEventListener('scroll', () => {
        mainNav.classList.toggle('slim', window.scrollY > 50);
    });
}

// Mobile hamburger
const hamburger = document.getElementById('hamburger');
const mobDrawer = document.getElementById('mobDrawer');
if (hamburger && mobDrawer) {
    hamburger.addEventListener('click', () => {
        mobDrawer.classList.toggle('open');
    });
}

// Fade-in on scroll (IntersectionObserver)
const fuEls = document.querySelectorAll('.fu');
const fuObserver = new IntersectionObserver((entries) => {
    entries.forEach(e => {
        if (e.isIntersecting) {
            e.target.classList.add('visible');
            fuObserver.unobserve(e.target);
        }
    });
}, { threshold: 0.1 });
fuEls.forEach(el => fuObserver.observe(el));

// Countdown timer
function updateCountdown() {
    const now = new Date();
    const target = new Date(now.getFullYear(), 11, 31, 23, 59, 59);
    if (now > target) target.setFullYear(target.getFullYear() + 1);
    const diff = target - now;
    const d = Math.floor(diff / 86400000);
    const h = Math.floor((diff % 86400000) / 3600000);
    const m = Math.floor((diff % 3600000) / 60000);
    const s = Math.floor((diff % 60000) / 1000);
    const pad = n => String(n).padStart(2, '0');
    const setEl = (id, val) => { const el = document.getElementById(id); if (el) el.textContent = pad(val); };
    setEl('cd-d', d); setEl('cd-h', h); setEl('cd-m', m); setEl('cd-s', s);
}
if (document.getElementById('cd-d')) {
    updateCountdown();
    setInterval(updateCountdown, 1000);
}

// Clan search & filter
const clanSearch = document.getElementById('clanSearch');
const clanCards = document.querySelectorAll('.clan-card-pro[data-name]');
const filterPills = document.querySelectorAll('.clan-filter-pill');
const clanCount = document.getElementById('clanCount');

function filterClans() {
    const q = clanSearch ? clanSearch.value.toLowerCase() : '';
    const activeFilter = document.querySelector('.clan-filter-pill.active')?.dataset.filter || 'All';
    let visible = 0;
    clanCards.forEach(card => {
        const name = card.dataset.name?.toLowerCase() || '';
        const totem = card.dataset.totem?.toLowerCase() || '';
        const head = card.dataset.head?.toLowerCase() || '';
        const isOrig = card.dataset.orig === 'true';
        const isRoyal = card.dataset.royal === 'true';
        const matchQuery = !q || name.includes(q) || totem.includes(q) || head.includes(q);
        const matchFilter = activeFilter === 'All'
            || (activeFilter === 'Original 5' && isOrig)
            || (activeFilter === 'Royal' && isRoyal)
            || (activeFilter === 'Other' && !isOrig && !isRoyal);
        const show = matchQuery && matchFilter;
        card.style.display = show ? '' : 'none';
        if (show) visible++;
    });
    if (clanCount) clanCount.textContent = visible;
}

if (clanSearch) clanSearch.addEventListener('input', filterClans);
filterPills.forEach(pill => {
    pill.addEventListener('click', () => {
        filterPills.forEach(p => p.classList.remove('active'));
        pill.classList.add('active');
        filterClans();
    });
});

// Masaza list interaction
const sazaItems = document.querySelectorAll('.saza-list-item');
const detailName = document.getElementById('detail-name');
const detailChief = document.getElementById('detail-chief');
const detailDesc = document.getElementById('detail-desc');
const detailKnown = document.getElementById('detail-known');

sazaItems.forEach(item => {
    item.addEventListener('click', () => {
        sazaItems.forEach(i => i.classList.remove('active'));
        item.classList.add('active');
        if (detailName) detailName.textContent = item.dataset.name;
        if (detailChief) detailChief.textContent = 'Saza Chief: ' + item.dataset.chief;
        if (detailDesc) detailDesc.textContent = item.dataset.desc;
        if (detailKnown) detailKnown.textContent = item.dataset.known;
    });
});

// Gallery lightbox
const lightbox = document.getElementById('lightbox');
const lightboxImg = document.getElementById('lightboxImg');
const lightboxTitle = document.getElementById('lightboxTitle');
const lightboxSub = document.getElementById('lightboxSub');
document.querySelectorAll('.gal-item').forEach(item => {
    item.addEventListener('click', () => {
        if (lightbox && lightboxImg) {
            lightboxImg.src = item.dataset.src;
            if (lightboxTitle) lightboxTitle.textContent = item.dataset.title;
            if (lightboxSub) lightboxSub.textContent = item.dataset.sub;
            lightbox.classList.add('open');
        }
    });
});
if (lightbox) {
    lightbox.addEventListener('click', () => lightbox.classList.remove('open'));
}

// Business tabs
document.querySelectorAll('.tab-btn').forEach(btn => {
    btn.addEventListener('click', () => {
        const tab = btn.dataset.tab;
        document.querySelectorAll('.tab-btn').forEach(b => b.classList.remove('active'));
        btn.classList.add('active');
        document.querySelectorAll('.biz-panel').forEach(p => {
            p.style.display = p.dataset.tab === tab ? 'grid' : 'none';
        });
    });
});

// Invitation personalise
const invNameInput = document.getElementById('invName');
const invPreviewName = document.getElementById('invPreviewName');
const invForm = document.getElementById('invForm');
const invPreview = document.getElementById('invPreview');
const invPreviewBtn = document.getElementById('invPreviewBtn');
const invEditBtn = document.getElementById('invEditBtn');

if (invPreviewBtn) {
    invPreviewBtn.addEventListener('click', () => {
        if (invPreviewName) invPreviewName.textContent = (invNameInput?.value.trim()) || 'Honoured Guest';
        if (invForm) invForm.style.display = 'none';
        if (invPreview) invPreview.style.display = 'block';
    });
}
if (invEditBtn) {
    invEditBtn.addEventListener('click', () => {
        if (invForm) invForm.style.display = 'block';
        if (invPreview) invPreview.style.display = 'none';
    });
}

// Contact form
const contactForm = document.getElementById('contactForm');
const contactSuccess = document.getElementById('contactSuccess');
const contactSubmit = document.getElementById('contactSubmit');
if (contactSubmit) {
    contactSubmit.addEventListener('click', () => {
        if (contactForm) contactForm.style.display = 'none';
        if (contactSuccess) contactSuccess.style.display = 'block';
    });
}
const contactReset = document.getElementById('contactReset');
if (contactReset) {
    contactReset.addEventListener('click', () => {
        if (contactForm) contactForm.style.display = 'block';
        if (contactSuccess) contactSuccess.style.display = 'none';
    });
}
