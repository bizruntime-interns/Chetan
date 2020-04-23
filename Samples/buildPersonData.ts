export function buildPersonalData({ firstname, lastname }, ...address) {
    return `${firstname} ${lastname} ${address}`;
}